using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul03_Enumeratoren
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mühseelige Form
            string[] anrede = new string[5];
            anrede[0] = "Frau";
            anrede[1] = "Herr";
            anrede[2] = "Dr.";
            anrede[3] = "Dipl.";
            anrede[4] = "Magister";


            //..... mal angenommen du siehst diese defnition nicht mehr 13->18 

            Console.WriteLine(anrede[1]);


            if (anrede[1] == "Herr")
            {

            }
            #endregion
            #region Bessere Variante als bei Arrays
            AnredeFormen wasBinIch = AnredeFormen.DrDr;

            if (wasBinIch == AnredeFormen.DrDr)
            {

            }

            #endregion

            
            for (int i = 1; i <= Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }


            //Speichern einer Benutzereingabe (Int) als Enumerator
            Wochentag heute;

            int wochentagIndex = int.Parse(Console.ReadLine());
            heute = ((Wochentag)wochentagIndex);
            Console.WriteLine($"Heute ist also {heute}.");

            if (heute == Wochentag.Montag)
            {
                //......hier passiert irgendwas
            }
            else if (heute == Wochentag.Dienstag)
            {
                //......
            }
            else if (heute == Wochentag.Mittwoch)
            {
                //machwas
            }
            else if (heute == Wochentag.Donnerstag)
            {
                //......
            }
            else if (heute == Wochentag.Freitag)
            {
                //machwas
            }
            else 
            {
                Console.WriteLine("Es ist Wochenende!!!");
            }


            switch (heute)
            {
                case Wochentag.Montag:
                    //Logikblock

                    break;
                case Wochentag.Dienstag:
                    break;
                case Wochentag.Mittwoch:
                    //einige Zeilen oder ein Verweis auf eine Methode oder Funktion etc. 
                    break;
                case Wochentag.Donnerstag:
                    break;
                case Wochentag.Freitag:
                    break;
                default:
                    Console.WriteLine("Es ist Wochenende!!!");
                    break;
            }

            int a = 11;

            switch(a)
            {
                case 5:
                    Console.WriteLine("a = 5");
                    break;

                // a wird in b eingelegt(zu überprüfende Variable wir für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int b when b > 10:
                    Console.WriteLine("a > 10");
                    break;
                default:
                    Console.WriteLine("a ist irgendwas");
                    break;
            }
            Console.ReadKey();

        }
    }
    enum Wochentag { Montag=1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }
    public enum AnredeFormen { Frau, Herr, Dr, DrDr, Diplom, Magister}
}
