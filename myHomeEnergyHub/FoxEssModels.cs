using System;
using System.Collections.Generic;

namespace myHomeEnergyHub
{
    class FoxEssModels
    {
    }

    public class SolarRow
    {
        public string Period { get; set; }

        // REAL date used for database and duplicate detection
        public DateTime Date { get; set; }

        // PRETTY date used only for UI
        public string DisplayDate { get; set; }

        public decimal FeedIn { get; set; }
        public decimal GridConsumption { get; set; }
        public decimal ChargeEnergy { get; set; }
        public decimal DischargeEnergy { get; set; }
        public decimal Loads { get; set; }
        public decimal PVEnergy { get; set; }
    }

    public class FoxResultItem
    {
        public string unit { get; set; }
        public decimal[] values { get; set; }
        public string variable { get; set; }
    }

    public class FoxResponse
    {
        public int errno { get; set; }
        public string msg { get; set; }
        public List<FoxResultItem> result { get; set; }
    }

    public class FoxDailyEnergyResponse
    {
        public int code { get; set; }
        public string msg { get; set; }
        public FoxDailyEnergyData data { get; set; }
    }

    public class FoxDailyEnergyData
    {
        public decimal pvEnergy { get; set; }
        public decimal gridImport { get; set; }
        public decimal gridExport { get; set; }
        public decimal batteryCharge { get; set; }
        public decimal batteryDischarge { get; set; }
        public decimal loadEnergy { get; set; }
    }

}
