using System;

namespace myHomeEnergyHub
{
    public class CombinedConsumption
    {
        public DateTime interval_start { get; set; }
        public DateTime interval_end { get; set; }

        public decimal? Import { get; set; }
        public decimal? Export { get; set; }
    }
}
