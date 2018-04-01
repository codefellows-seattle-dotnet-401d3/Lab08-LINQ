using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace LINQManhattan
{

    public class Features
    {
        public string Type { get; set; }
        public Properties Properties { get; set; }
        public Geometry Geometry { get; set; }

        public class FeaturesCollection
        {
            public string Type { get; set; }
            public List<Features> Features { get; set; }
        }
    }
}
