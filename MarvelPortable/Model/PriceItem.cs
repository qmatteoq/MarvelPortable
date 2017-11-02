using Newtonsoft.Json;
using PropertyChanged;

namespace MarvelPortable.Model
{
    [AddINotifyPropertyChangedInterface]
    public class PriceItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }
}