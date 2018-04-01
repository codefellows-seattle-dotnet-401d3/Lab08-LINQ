using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * using NewtonSoft to turn JSON data into Generics collection
 * then use LINQ expression to parse thru data to search for 
 */
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creating a string this is the start 
             */
            string manhattan;
            using (StreamReader r = new StreamReader("data.json"))
            {
                manhattan = r.ReadToEnd();
            };

            Console.WriteLine(manhattan);


    
           
      
        }

       
       



     

    }
}
