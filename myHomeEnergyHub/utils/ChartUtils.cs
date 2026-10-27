using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using myHomeEnergyHub;

public static class ChartUtils
{
    public static void PrepareChart(Chart chart, string dimension)
    {
        chart.Series.Clear();
        chart.ChartAreas.Clear();

        var area = new ChartArea("MainArea");

        area.AxisY.MajorGrid.LineColor = Color.LightGray;
        area.AxisX.MajorGrid.Enabled = false;

        if (dimension == "day")
        {
            area.AxisX.LabelStyle.Format = "HH:mm";
            area.AxisX.IntervalType = DateTimeIntervalType.Hours;
            area.AxisX.Interval = 1;

        }
        else
        {
            area.AxisX.LabelStyle.Format = "";
            area.AxisX.IntervalType = DateTimeIntervalType.Number;
            area.AxisX.Interval = 1;

        }

        chart.ChartAreas.Add(area);
    }

    public static void SetChartTitle(Chart chart, string dimension, DateTime date)
    {
        chart.Titles.Clear();

        string title = "Solar Chart";

        switch (dimension)
        {
            case "day":
                title += $" — {date:dd MMM yyyy}";
                break;
            case "month":
                title += $" — {date:MMM yyyy}";
                break;
            case "year":
                title += $" — {date:yyyy}";
                break;
        }

        chart.Titles.Add(title);
        chart.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
    }

    public static void AddSeries(Chart chart, string name, Color color, List<decimal> values, DateTime date, string dimension)
    {
        var series = new Series(name)
        {
            ChartType = SeriesChartType.Line,
            Color = color,
            BorderWidth = 2
        };

        for (int i = 0; i < values.Count; i++)
        {
            int p;

            if (dimension == "day")
            {
                DateTime xTime = date.Date.AddHours(i);
                double xValue = xTime.ToOADate();

                p = series.Points.AddXY(xValue, (double)values[i]);
                series.Points[p].ToolTip = $"{name}: {values[i]:0.###} at {xTime:HH:mm}";
            }
            else
            {
                p = series.Points.AddXY(i + 1, (double)values[i]);
                series.Points[p].ToolTip = $"{name}: {values[i]:0.###}";
            }
        }

        chart.Series.Add(series);
    }

    public static void ApplyXAxisLabels(Chart chart, List<SolarRow> rows, string dimension)
    {
        var area = chart.ChartAreas[0];
        area.AxisX.CustomLabels.Clear();

        if (dimension == "day")
        {
            area.AxisX.LabelStyle.Format = "HH:mm";
            area.AxisX.IntervalType = DateTimeIntervalType.Hours;
            area.AxisX.Interval = 1;
            return;
        }

        area.AxisX.LabelStyle.Format = "";
        area.AxisX.IntervalType = DateTimeIntervalType.Number;
        area.AxisX.Interval = 1;

        for (int i = 0; i < rows.Count; i++)
        {
            var lbl = new CustomLabel
            {
                FromPosition = i + 0.5,
                ToPosition = i + 1.5,
                Text = dimension == "month"
                    ? $"Day {i + 1}"
                    : CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1)
            };

            area.AxisX.CustomLabels.Add(lbl);
        }
    }

    public static void AddSunriseSunsetShading(Chart chart, DateTime date, double latitude, double longitude)
    {
        var sun = new Sunriset();
        double sunriseUTC = sun.CalculateSunTime(date, latitude, longitude, true);
        double sunsetUTC = sun.CalculateSunTime(date, latitude, longitude, false);

        DateTime sunrise = date.Date.AddHours(sunriseUTC).ToLocalTime();
        DateTime sunset = date.Date.AddHours(sunsetUTC).ToLocalTime();

        double sunriseX = sunrise.ToOADate();
        double sunsetX = sunset.ToOADate();

        var area = chart.ChartAreas[0];

        DateTime yesterday = date.AddDays(-1);
        DateTime start = yesterday.Date.AddHours(23).AddMinutes(00);
        DateTime end = date.Date;

        // Y-axis to start of day
        area.AxisX.StripLines.Add(new StripLine
        {
            BackColor = Color.FromArgb(40, Color.DarkBlue),
            IntervalOffset = start.ToOADate(),
            StripWidth = end.ToOADate() - start.ToOADate()
        });


        // Night before sunrise
        area.AxisX.StripLines.Add(new StripLine
        {
            BackColor = Color.FromArgb(40, Color.DarkBlue),
            IntervalOffset = date.Date.ToOADate(),
            StripWidth = sunriseX - date.Date.ToOADate()
        });

        // Daytime
        area.AxisX.StripLines.Add(new StripLine
        {
            BackColor = Color.FromArgb(40, Color.Yellow),
            IntervalOffset = sunriseX,
            StripWidth = sunsetX - sunriseX
        });

        // Night after sunset
        area.AxisX.StripLines.Add(new StripLine
        {
            BackColor = Color.FromArgb(40, Color.DarkBlue),
            IntervalOffset = sunsetX,
            StripWidth = date.Date.AddDays(1).ToOADate() - sunsetX
        });

        // Sunrise line
        area.AxisX.StripLines.Add(new StripLine
        {
            BorderColor = Color.Red,
            BorderWidth = 1,
            IntervalOffset = sunriseX,
            ToolTip = $"Sunrise: {sunrise:HH:mm}"
        });

        // Sunset line
        area.AxisX.StripLines.Add(new StripLine
        {
            BorderColor = Color.Red,
            BorderWidth = 1,
            IntervalOffset = sunsetX,
            ToolTip = $"Sunset: {sunset:HH:mm}"
        });
    }
}
