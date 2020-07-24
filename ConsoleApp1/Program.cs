using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string aufbauenderString = string.Empty;

            Stopwatch stopuhr = new Stopwatch();

            stopuhr.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
                aufbauenderString += i.ToString();
            }
            stopuhr.Stop();

            long test1 = stopuhr.ElapsedMilliseconds;

            Console.WriteLine("Taste drücken");
            Console.ReadKey();


            StringBuilder builder = new StringBuilder();

            Stopwatch stopuhr2 = new Stopwatch();
            stopuhr2.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
                builder.Append(i);
            }
            stopuhr2.Stop();

            long test2 = stopuhr2.ElapsedMilliseconds;


            Console.WriteLine("Benchmark Ergebnis");
            Console.WriteLine(test1);
            Console.WriteLine(test2);
          
            Console.ReadKey();




        }
    }
}
