using System;
using Newtonsoft.Json;
using PropertyChanged;

namespace MarvelPortable.Model
{
    [AddINotifyPropertyChangedInterface]
    public class DateItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}