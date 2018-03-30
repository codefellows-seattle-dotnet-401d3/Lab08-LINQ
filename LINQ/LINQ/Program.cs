using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            string mypath = "..//data.json";
            Fil
           
      
        }

        public static void ReadFile(string mypath)
        {
            try
            {
                using (StreamReader sr = File.OpenText(mypath))
                {
                    string s = " ";
                    while ((s = sr.ReadLine() != null))
                    {
                        Console.WriteLine()
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
       



     

    }
}
