using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string manhattan;
            string path = @"..\..\..\data.json";
            using (StreamReader r = new StreamReader(path))
            {
                manhattan = r.ReadToEnd();
            };

            FeaturesCollection items = JsonConvert.DeserializeObject<FeaturesCollection>(manhattan);

            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("All Neighborhoods");
            
            // Query to get all neighborhoods that aren't null
            var allHoods = from n in items.Features
                           where n.Properties.Neighborhood != null
                           select n;

            foreach (var hood in allHoods)
            {
                Console.WriteLine(hood.Properties.Neighborhood);
            }

            Console.WriteLine("Press any key to continue to next query.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Non Blank Neighborhoods");

            // Query to get all neighborhoods that are not blank from the previous query
            var noBlankHood = allHoods.Where(b => b.Properties.Neighborhood != "");

            foreach (var nonBlank in noBlankHood)
            {
                Console.WriteLine(nonBlank.Properties.Neighborhood);
            }

            Console.WriteLine("Press any key to continue to next query.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Unique Neighborhoods");

            // Query to get one of each neighborhood, it groups 
            // all neighborhoods together then gets the first of each group
            var uniqueHoods = noBlankHood.GroupBy(u => u.Properties.Neighborhood).Select(f => f.First());

            foreach (var unique in uniqueHoods)
            {
                Console.WriteLine(unique.Properties.Neighborhood);
            }

            Console.WriteLine("Press any key to continue to next query.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("All at once");

            // Does the first three queries in one line
            var inOneGo = items.Features.Where(x => x.Properties.Neighborhood != null)
                                        .Where(x => x.Properties.Neighborhood != "")
                                        .GroupBy(x => x.Properties.Neighborhood)
                                        .Select(u => u.First());
            foreach (var item in inOneGo)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
            Console.WriteLine("Press any key to continue to next query.");
            Console.ReadKey();
        }

 

        
    }
}
