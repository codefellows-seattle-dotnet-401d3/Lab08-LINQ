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
            using (StreamReader r = new StreamReader("data.json"))
            {
                manhattan = r.ReadToEnd();
            };
            FeaturesCollection items = JsonConvert.DeserializeObject<FeaturesCollection>(manhattan);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("All Neighborhoods");
            var allHoods = from n in items.Features
                           where n.Properties.Neighborhood != null
                           select n;
            foreach (var hood in allHoods)
            {
                Console.WriteLine(hood.Properties.Neighborhood);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Non Blank Neighborhoods");
            var noBlankHood = allHoods.Where(b => b.Properties.Neighborhood != "");
            foreach (var nonBlank in noBlankHood)
            {
                Console.WriteLine(nonBlank.Properties.Neighborhood);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Unique Neighborhoods");
            var uniqueHoods = noBlankHood.GroupBy(u => u.Properties.Neighborhood).Select(f => f.First());
            foreach (var unique in uniqueHoods)
            {
                Console.WriteLine(unique.Properties.Neighborhood);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("All at once");
            var inOneGo = items.Features.Where(x => x.Properties.Neighborhood != null)
                                        .Where(x => x.Properties.Neighborhood != "")
                                        .GroupBy(x => x.Properties.Neighborhood)
                                        .Select(u => u.First());
            foreach (var item in inOneGo)
            {
                Console.WriteLine(item.Properties.Neighborhood);
            }
            Console.ReadLine();
        }

 

        
    }
}
