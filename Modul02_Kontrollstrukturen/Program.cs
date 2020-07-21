using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 25;
            int b = 30;
            int c = 20;



            #region If/Else if / else
            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            //Es kann beliebig viele ELSE-IF-Blöcke geben
            else if (a > b)
            {
                Console.WriteLine("B ist kleiner als A");
            }
            //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
            else
                Console.WriteLine("A ist gleich B");

            //Kurznotation:
            //(Bedienung) ? TrueAusgabe : FalseAusgabe

            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";
            bool stimmtDieAussage = (a == b) ? true : false; 

            
                //ÜBersetzt würde das heißen
            if (a == b)
                ergebnis = "A ist gleich B";
            else
                ergebnis = "A ist ungleich B";


            //AND - Verknüpfung
            if (a==26 && c==20)
            {
                Console.WriteLine("a hat den Wert 26 und c hat den Wert 20");
            }
            else if (a == 25 && c == 20)
            {
                Console.WriteLine("a hat den Wert 25 und c hat den Wert 20");
            }


            if (a==10||b==5)
            {
                Console.WriteLine("a hat den Wert 10 und b hat den Wert 5");
            }
            else if (a == 10 || c == 20)
            {
                Console.WriteLine("a hat den Wert 10 oder c hat den Wert 20");
            }
            #endregion


            //a=25
            //b=30

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while ( a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
                a++;

                if (a == 28)
                    break;
                
                // Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
            }




            a = 200;
            do
            {
                Console.WriteLine($"{a} ist kleiner als 100");
                a *= 2;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;
                //hier kmme ich nicht mehr hin

            } while (a < 100);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Dies ist Durchlauf Nr. {i}");
            }

            for (int i = 0; i < 10; i += 2)
            {
               
                Console.WriteLine($"Dies ist Durchlauf Nr. {i}");
            }

            
            for (int superMarioLeben = 3; superMarioLeben > 0; superMarioLeben--)
            {
                Console.WriteLine($"Super Mario Leben > {superMarioLeben}");
            }


            //Bitte nicht nachmachen
            int abc = 0;
            for (;abc < 100; abc++)
            {

            }

            //Auch dies nicht nachmachen
            int cde = 5;
            for (; ;cde++ )
            {
                Console.WriteLine($"Super Mario Leben > {cde}");

                if (cde > 10000)
                    break;
            }



            Console.ReadKey();

        }
    }
}
