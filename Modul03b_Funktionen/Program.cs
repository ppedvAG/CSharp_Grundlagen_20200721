using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul03b_Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Out Parameter-Beispiel");
            int zahl1 = 10;
            int zahl2 = 20;

            //Wertetypen geben eine Kopie von sich in die Methode über
            AddiereUndSubtrahiere(zahl1, out zahl2);

            Console.WriteLine($"Zahl1>{zahl1}");
            Console.WriteLine($"Zahl2>{zahl2}");

            Console.WriteLine("Params-Beispiel");
            KeyInputWaiter();

            //Weitere Beispiele
            //Aufruf der Params-Funktion mit Übergabe eines Arrays, einer bleiebigen Anzahl von Ints und nichts
            double summe = AddiereBeliebigeAnzahl(new int[] { 2, 4, 5, 6, 5, 3, 4, 5, 43 });
            summe = AddiereBeliebigeAnzahl(7, 8, 9, 45, 12, 741);
            summe = AddiereBeliebigeAnzahl();

            Console.WriteLine("Weiter zu unserem Taschenrechner");
            KeyInputWaiter();

            while (true)
            {
                PrintMenue();
            }



            
        }

        public static int AddiereUndSubtrahiere(int a, out int b)
        {
            b = 11;
            return a + b;
        }

        //Das OUT-Stichwort ermöglich einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der Funktions-
        ///übergabe deklariert werden
        public static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }

        public static int AddiereBeliebigeAnzahl(params int[] summanden)
        {
            int summe = 0;

            foreach (var item in summanden)
            {
                summe += item; //summe = summe + item
            }
            return summe;
        }

        static void PrintMenue()
        {
            Console.Clear();
            Console.WriteLine("Taschenrechner - Menü");
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subraktion");
            Console.WriteLine("(3) Multiplikation");
            Console.WriteLine("(4) Division");
            Console.WriteLine("(x) Exit");

            Console.Write("Auswahl>");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            Console.WriteLine();


            double ergebnis = 0;
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:

                    ergebnis = Addiere(10);
                    Addiere(5, 7);
                    AddiereAdvanced(10, 11, 13, 14);
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.X:
                    Environment.Exit(0);
                    break;
                default:
                    PrintMenue();
                    break;
            }

            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            KeyInputWaiter();
        }

        public static void KeyInputWaiter()
        {
            Console.WriteLine("##### Bitte eine Taste eingeben");
            Console.ReadKey();
        }

        public static void Addiere ()
        {
            Console.Write("Eingabe des ersten Summanden> ");
            double summand1 = double.Parse(Console.ReadLine());

            Console.Write("Eingabe des zweiten Summanden> ");
            double summand2 = double.Parse(Console.ReadLine());


            double summe = summand1 + summand2;
            Console.WriteLine($"Die Summe ist > {summe}");

            KeyInputWaiter();
        }

        //Überschreiben die Methode addieren 
        public static double Addiere(double summand1, double summand2=0)
        {
            double summe = summand1 + summand2;

            return summe;
        }

        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int AddiereAdvanced(int a, int b, int c = 0, int d = 0)
        {
            int summe = a + b + c + d;
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return summe;
        }

        /// <summary>
        /// Hallo liebe Teilnehmer
        /// </summary>
        /// <param name="zahl1">Das ist der erste Parameter</param>
        /// <param name="zahl2">Danach kommt der zweiter Parameter</param>
        /// <returns>Und das Ergebnis ist eine Summe</returns>
        public static int Addiere(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }


        public static double Addiere(double x, double y, double xyz)
        {
            double summe = x + y;

            return summe;
        }

        

    }
}
