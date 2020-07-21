using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zeige einmal Hello World an
            Console.WriteLine("Hello World");

            //Deklaration einer Integer-Variable
            int alter = 10;
            //Initialisierung einer Variable
            alter = 20;

            string stadt = "Berlin";
            // Ganze Zeile wird ausgegegeben + Zeilenumbruch
            Console.WriteLine(stadt);

            // Alterausgabe mit Zeilenumbruch
            Console.WriteLine(alter);

            //Vorlaufende Ausagabe -> Zeilenumbruch wird ab einer gewisscen Zeichenanzahl getätigt.
            Console.Write(stadt);
            Console.Write(alter);

            stadt = "Hamburg";
            Console.WriteLine(stadt);

            #region String-Ausgaben


            string SatzDesTages = "In der Stadt " + stadt + " ist der jüngster Bürgermeister " + alter.ToString() + " Jahre alt";  //Schlechter Code

            //kommt aus der Sprache C -> hier wird der Befehl printf nachgestellt
            Console.WriteLine("Stadtname: {0}, das Alter {1}", stadt, alter);
            //neueste Variante
            Console.WriteLine($"Stadtname: {stadt}, das Alter {alter}"); //C#6 


            int a = 15;
            int b = 23;
            int summer = a + b;
            Console.WriteLine($"{a} + {b} = {a + b}");

            //String-Formatierung Escape-Zeichen
            Console.WriteLine("Hallo liebe\tTeilnehmer! Ich hoffe der Kurs wird euch allen sehr viel Spaß machen!\nIch hoffe dieser Text steht in einer neuen Zeile ");

            Console.WriteLine("C:\\Programme\\Spiele\\Tetris");
            
            // Bsp für Pfadausgabe in Verbatim - String
            Console.WriteLine(@"C:\Programme\Spiele\Tetris2");
            Console.WriteLine(@"Hallo liebe\tTeilnehmer! Ich hoffe der Kurs wird euch allen sehr viel Spaß machen!\nIch hoffe dieser Text steht in einer neuen Zeile ");
            #endregion

            #region String-Eingaben

            //Eingabe + Konventierung
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            string zahlAlsString = Console.ReadLine();
            int umgewandelteZahl = int.Parse(zahlAlsString);
            int doppelteZahl = umgewandelteZahl * 2;
            Console.WriteLine(doppelteZahl);

            //Int->Double
            double kommazahl = double.Parse(zahlAlsString);

            //beispiel: Kommazahl = 10,5 -> ganzeZahl wäre 10
            int ganzeZahl = (int)kommazahl;
            #endregion



            #region Konventierungsmöglichkeiten einer Double -> Integer. 
            double kommaZahl = 10.5;

            //Variante 1
            int ergebnis1 = (int)kommaZahl;
            Console.WriteLine($"int ergebnis1 = (int)kommaZahl; -> {ergebnis1}");
            //Variante 2
            int ergebnis2 = Convert.ToInt32(kommaZahl);
            Console.WriteLine($" int ergebnis2 = Convert.ToInt32(kommaZahl); -> {ergebnis2}");

            //Variante 3
            //int ergebnis3 = int.Parse(kommaZahl.ToString());
            //Console.WriteLine($"int ergebnis3 = int.Parse(kommaZahl.ToString()); -> {ergebnis3}");


            #endregion


            #region Inkrementieren / Dekrementieren
            a = 11;
            b = 17;

            
            Console.WriteLine(a);

            Console.WriteLine((a++)); //a++ bedeutet eigentlich erhöhe um 1

            Console.WriteLine(++b); //++b bedeutet erigentlich erhöhe um 1


            #endregion


            Console.ReadKey();


            
        }

        
    }
}
