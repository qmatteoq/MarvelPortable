using Newtonsoft.Json;
using PropertyChanged;

namespace MarvelPortable.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Url
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Uri { get; set; }
    }
}