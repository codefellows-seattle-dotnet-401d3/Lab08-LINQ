using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQManhattan
{
    [JsonObject(MemberSerialization.OptIn)]

    public class FeaturesCollection
    {
        [JsonProperty]
        public String Type {get; set;}

        [JsonProperty]
        public List<Features> Features { get; set;}
    }
}
