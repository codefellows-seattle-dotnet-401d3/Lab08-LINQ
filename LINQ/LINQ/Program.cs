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

            foreach (var item in jObject.features)
            {
                Console.WriteLine(item.properties.neighborhood);
                Console.ReadLine();
            }
         
        }


    }
}

