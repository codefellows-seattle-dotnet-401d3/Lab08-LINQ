using LINQManhattan;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
 * using NewtonSoft to turn JSON data into Generics collection
 * then use LINQ expression to parse thru data to search for 
 */
namespace LINQ
{
    class Program
    {

        /* After installing the NewtonSoft package, create a string file path
         * to where my data source is in the case data.JSON. Using the System.text, using Deserialized Objects
         * 
         */
        static void Main(string[] args)
        {
            string filePath = "../../../data.json";
            StreamReader sr = new StreamReader(filePath);

            var jObject = JsonConvert.DeserializeObject<JSONTransferObject>(sr.ReadLine());

            //ouputs all data of the neighborhood
            foreach (var item in jObject.features)
            {
                Console.WriteLine(item.properties.neighborhood);
                Console.ReadLine();
            }

            /* LINQ queries
             * 
             */
            //outputs all data with neighborhood with no names
            IEnumerable<string> neighborhood = from Feature in jObject.features
                                               where Feature.properties.neighborhood != null
                                               select Feature.properties.neighborhood;
            foreach (string item in neighborhood)
            {
                Console.WriteLine("Neighborhoods with no empty data");
                Console.WriteLine(item);
            }
            Console.ReadLine();






            IEnumerable<string> fullFilter = from item in jObject.features
                                             where item.properties.neighborhood != null
                                             select item.properties.neighborhood;

            foreach (string item in fullFilter)
            {
                Console.WriteLine(item);
            }

            //Lambda expression
            IEnumerable<Feature> features = jObject.features.Where(item => item.properties.neighborhood != null).Distinct();
            foreach (string item in fullFilter)
            {
                Console.WriteLine(item);
            }

         

        

        }


    }
}

