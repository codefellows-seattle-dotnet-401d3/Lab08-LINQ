using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQManhattan
{
    public class Geometry
    {
        public string Type { get; set; }

        [JsonProperty]
        public double[] coordinates { get; set; }
    }
}
