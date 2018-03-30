using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../../../data.json";

            StreamReader sr = new StreamReader(filePath);

            var jObject = JsonConvert.DeserializeObject<JSONTransferObject>(sr.ReadLine());

            //jObject.features[0].properties.neighborhood

            foreach (var item in jObject.features)
            {
                Console.WriteLine(item.properties.neighborhood);
            }

            Console.ReadLine();

            //IEnumerable<string>
        }


        public static JSONTransferObject DeserializeJSON(string strJSON)
        {
            var jObject = JsonConvert.DeserializeObject<JSONTransferObject>(strJSON);

            return jObject;
        }
    }
}
