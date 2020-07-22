using Modul04_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //unschönes Beispiel
            Fahrzeug fahrzeug = new Fahrzeug();
            fahrzeug.Baujahr = 1999;
            fahrzeug.Marke = "BMW";
            fahrzeug.Modell = "Z8";
            fahrzeug.MaxGeschwindigkeit = 250;


            Fahrzeug auto = new Fahrzeug(1999, "BMW", "Z8", 250);

            Fahrzeug autoVersion2 = new Fahrzeug(2020, "Fiat", "Punto", 280, "Blau");

            autoVersion2.StarteMotor();
            autoVersion2.Beschleunigung(150);
            Console.WriteLine(autoVersion2.Display());
            autoVersion2.Beschleunigung(150);
            Console.WriteLine(autoVersion2.Display());


           
            Fahrzeug autoVersion3 = new Fahrzeug(2019, "Fiat", "Punto", 130, "Blau");
            Fahrzeug autoVersion4 = new Fahrzeug(2018, "BMW", "Z8", 220, "Rot");
            Fahrzeug autoVersion5 = new Fahrzeug(2017, "Porsche", "xyz", 280, "Schwarz");
            Fahrzeug autoVersion6 = new Fahrzeug(2016, "Audi", "Quatro", 240, "Sibler");


            Fahrzeug.KmhToMph(123);

        }
    }
}
