using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static myHomeEnergyHub.Form1;

namespace myHomeEnergyHub
{
    public static class Database
    {
        public static string DbPath =>
            System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "energy.db");

        public static OverwriteChoice overwriteMode = OverwriteChoice.Skip; // default



        public static void Initialize()
        {
            if (!System.IO.File.Exists(DbPath))
            {
                SQLiteConnection.CreateFile(DbPath);
            }

            using (var conn = new SQLiteConnection("Data Source=" + DbPath))
            {
                conn.Open();

                string sqlElectric = @"
                CREATE TABLE IF NOT EXISTS ElectricityConsumption (
                    interval_start TEXT PRIMARY KEY,
                    interval_end TEXT,
                    import REAL,
                    export REAL
                );
            ";

                string sqlGas = @"
                CREATE TABLE IF NOT EXISTS GasConsumption (
                    interval_start TEXT PRIMARY KEY,
                    interval_end TEXT,
                    consumption REAL
                );
            ";

                string sqlSolar = @"
                CREATE TABLE IF NOT EXISTS SolarDaily(
                    date TEXT PRIMARY KEY,
                    pvEnergy REAL,
                gridImport REAL,
                    gridExport REAL,
                batteryCharge REAL,
                    batteryDischarge REAL,
                loadEnergy REAL
                    );";


                using (var cmd = new SQLiteCommand(sqlElectric, conn))
                    cmd.ExecuteNonQuery();

                using (var cmd = new SQLiteCommand(sqlGas, conn))
                    cmd.ExecuteNonQuery();
            }
        }

        public static void InsertElectricity(CombinedConsumption item)
        {
            using (var conn = new SQLiteConnection("Data Source=" + DbPath))
            {
                conn.Open();

                // Check if row exists
                string checkSql = "SELECT COUNT(*) FROM ElectricityConsumption WHERE interval_start = @start";
                using (var checkCmd = new SQLiteCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@start", item.interval_start.ToString("o"));
                    long count = (long)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        if (overwriteMode == OverwriteChoice.SkipAll)
                            return;

                        if (overwriteMode == OverwriteChoice.OverwriteAll)
                            goto DoInsert;

                        // Ask user
                        using (var dlg = new FormOverwriteDialog(
                                   $"Data for {item.interval_start} already exists.\nWhat would you like to do?"))
                        {
                            dlg.ShowDialog();

                            overwriteMode = dlg.Choice;

                            if (overwriteMode == OverwriteChoice.Skip)
                                return;

                            if (overwriteMode == OverwriteChoice.SkipAll)
                                return;

                            // Overwrite or OverwriteAll both fall through to insert
                        }
                    }

                }

            // Insert or replace
            DoInsert:
                string insertSql = @"
            INSERT OR REPLACE INTO ElectricityConsumption
            (interval_start, interval_end, import, export)
            VALUES (@start, @end, @import, @export);
        ";

                using (var cmd = new SQLiteCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", item.interval_start.ToString("o"));
                    cmd.Parameters.AddWithValue("@end", item.interval_end.ToString("o"));
                    cmd.Parameters.AddWithValue("@import", (object)item.Import ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@export", (object)item.Export ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void InsertGas(ConsumptionItem item)
        {
            using (var conn = new SQLiteConnection("Data Source=" + DbPath))
            {
                conn.Open();

                string checkSql = "SELECT COUNT(*) FROM GasConsumption WHERE interval_start = @start";
                using (var checkCmd = new SQLiteCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@start", item.interval_start.ToString("o"));
                    long count = (long)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        if (overwriteMode == OverwriteChoice.SkipAll)
                            return;

                        if (overwriteMode == OverwriteChoice.OverwriteAll)
                            goto DoInsert;

                        using (var dlg = new FormOverwriteDialog(
                                   $"Gas data for {item.interval_start} already exists.\nWhat would you like to do?"))
                        {
                            dlg.ShowDialog();

                            overwriteMode = dlg.Choice;

                            if (overwriteMode == OverwriteChoice.Skip)
                                return;

                            if (overwriteMode == OverwriteChoice.SkipAll)
                                return;
                        }
                    }

                }

            // Insert or replace
            DoInsert:
                string insertSql = @"
            INSERT OR REPLACE INTO GasConsumption
            (interval_start, interval_end, consumption)
            VALUES (@start, @end, @consumption);
            ";

                using (var cmd = new SQLiteCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", item.interval_start.ToString("o"));
                    cmd.Parameters.AddWithValue("@end", item.interval_end.ToString("o"));
                    cmd.Parameters.AddWithValue("@consumption", item.consumption);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertSolar(FoxDailyEnergyData item, DateTime date)
        {
            using (var conn = new SQLiteConnection("Data Source=" + DbPath))
            {
                conn.Open();

                string sql = @"
            INSERT OR REPLACE INTO SolarDaily
            (date, pvEnergy, gridImport, gridExport, batteryCharge, batteryDischarge, loadEnergy)
            VALUES (@date, @pv, @import, @export, @charge, @discharge, @load);
        ";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@pv", item.pvEnergy);
                    cmd.Parameters.AddWithValue("@import", item.gridImport);
                    cmd.Parameters.AddWithValue("@export", item.gridExport);
                    cmd.Parameters.AddWithValue("@charge", item.batteryCharge);
                    cmd.Parameters.AddWithValue("@discharge", item.batteryDischarge);
                    cmd.Parameters.AddWithValue("@load", item.loadEnergy);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}