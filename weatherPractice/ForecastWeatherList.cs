using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherPractice
{
    public class ForecastWeatherList
    {
        [JsonProperty("dt")]
        public int PredictionTime { get; set; }
        [JsonProperty("main")]
        public MainWeatherInfo MainInfo { get; set; }
        [JsonProperty("weather")]
        public List<Weather> ShortInfo { get; set; }
        [JsonProperty("wind")]
        public WindInfo WindInfo { get; set; }
        [JsonProperty("dt_txt")]
        public DateTime ForecastTime { get; set; }
    }
}
