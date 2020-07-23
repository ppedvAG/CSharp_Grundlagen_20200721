using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Abstract
{
    


    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        // GetArea method is required to avoid a compile-time error.
        public override double GetArea()
        {
            return side* side;
        }
    }
    // Output: Area of the square = 144



    class Program
    {
        static void Main(string[] args)
        {


            Square sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");

            Console.ReadKey();
        }
    }
}
