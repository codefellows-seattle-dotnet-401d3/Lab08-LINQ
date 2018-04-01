using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQManhattan
{

    public class JSONTransferObject
    {
        public string type { get; set; }
        public Feature[] features { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

}



