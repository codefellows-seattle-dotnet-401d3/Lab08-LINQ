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
            //Filepath for the JSON file
            string filePath = "../../../../../data.json";
            //Start up a streamreader to take in the file
            StreamReader sr = new StreamReader(filePath);
            //Convert the JSON to an Object
            var jObject = JsonConvert.DeserializeObject<JSONTransferObject>(sr.ReadLine());
            //Print all neighborhoods
            foreach (var item in jObject.features)
            {
                Console.WriteLine(item.properties.neighborhood);
            }

            Console.ReadLine();
            //Filter out the empty?
            IEnumerable<string> neighList = from feat in jObject.features
                                            where feat.properties.neighborhood != null
                                            select feat.properties.neighborhood;

            foreach (string item in neighList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //Filter out the dupes
            IEnumerable<string> filterDup = neighList.Distinct();
            foreach (var item in filterDup)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //Combine the queries into one
            IEnumerable<string> fullFilter = from item in jObject.features
                                             where item.properties.neighborhood != null
                                             select item.properties.neighborhood;
            //Lamda of the previous filter. It reaturns a feature though.
            IEnumerable<Feature> fullLamda =
                jObject.features.Where(item => item.properties.neighborhood != null).Distinct();
            foreach (var item in fullFilter.Distinct())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
