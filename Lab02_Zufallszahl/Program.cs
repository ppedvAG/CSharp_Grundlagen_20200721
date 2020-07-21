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

            while (!istZahlRichtig)
            {
                istZahlRichtig = false; ++;
                // 1) Eingabe der geratenen Zahl

                // 2) Prüfung der eingegeben Zahl mit der zufallzahl
                //+ Ausgabe: Zufallszahl ist größer oder kleiner

                // Oder richtig -> istZahlRichtig = true; -> Spiel ist beendet;
            }

            //Ausgabe der Versuche: Sie haben 5 Versuche gebraucht 






        }
    }
}
