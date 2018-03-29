using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQManhattan
{
    public class Geometry
    {
        public string Type { get; set; }
        [JsonProperty]
        public double[] Coordinates { get; set; }
    }
}
