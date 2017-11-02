﻿using Newtonsoft.Json;
using PropertyChanged;

namespace MarvelPortable.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Next
    {
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}