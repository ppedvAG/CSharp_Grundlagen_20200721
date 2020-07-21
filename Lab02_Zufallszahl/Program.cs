using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Zufallszahl
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Zufallszahl zwischen 1 - 100
            int zufallszahl = generator.Next(1, 100);
            bool istZahlRichtig = false;

            int tries = 0;

            int eingegebenZahl = 0;
            do
            {
                tries++;
                Console.Write("Zahl bitte eingeben > ");
                eingegebenZahl = int.Parse(Console.ReadLine());

                if (eingegebenZahl > zufallszahl)
                    Console.WriteLine("Eingegebene Zahl ist größer als Zufallszahl");
                else if (eingegebenZahl < zufallszahl)
                    Console.WriteLine("Eingegebene Zahl ist kleiner als Zufallszahl");

            } while (eingegebenZahl != zufallszahl);

            Console.WriteLine($"Sie haben die richtige Zahl erraten mit {tries} Versuchen");
            Console.ReadKey();
            //Ausgabe der Versuche: Sie haben 5 Versuche gebraucht 






        }
    }
}
