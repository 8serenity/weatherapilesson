using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherPractice
{
    public class MainWeatherInfo
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }
        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}
