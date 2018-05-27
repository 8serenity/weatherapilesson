using Newtonsoft.Json;
namespace weatherPractice
{
    public class WindInfo
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}