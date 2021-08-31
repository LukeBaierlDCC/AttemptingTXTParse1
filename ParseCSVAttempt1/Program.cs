using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseCSVAttempt1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rawCSV = System.IO.File.ReadAllText(@"C:\Users\lukee\Documents\CSV Files\videogameparse.csv");
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\lukee\Documents\CSV Files\videogameparse.txt");
            
            for (int i = 0; i < csvLines.Length; i++)
            {
                //Console.WriteLine(csvLines[i]);

                string[] rowData = csvLines[i].ToUpper().Split(',', ' ');
                for (int j = 0; j < rowData.Length; j++)
                {
                    Console.WriteLine(rowData[j]);
                }
            }
            
            Console.ReadKey();
        }
    }
}
