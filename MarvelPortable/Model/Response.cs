using Newtonsoft.Json;
using PropertyChanged;

namespace MarvelPortable.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Response<TResponseType> : MarvelBase
    {
        [JsonProperty("data")]
        public Data<TResponseType> Data { get; set; }
    }
}