using System;

namespace Git2App
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Summary1 { get; set; }

        public string Summary2 { get; set; }

        public string Summary3 { get; set; }

        public string Summary4 { get; set; }
        
        public string SummaryOnline5 { get; set; }
        
        public string SummaryOnline6 { get; set; }
        
        public string SummaryOnline7 { get; set; }
        
        public string SummaryOnline8 { get; set; }

        public string FromMain1Branch { get; set; }
        
        public string TestCICD { get; set; }
    }
}
