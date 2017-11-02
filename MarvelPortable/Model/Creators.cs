using Newtonsoft.Json;
using PropertyChanged;

namespace MarvelPortable.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Creators
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionUri { get; set; }

        [JsonProperty("items")]
        public CreatorItem[] Items { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
    }
}