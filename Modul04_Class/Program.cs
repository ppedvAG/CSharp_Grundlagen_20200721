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
            FahrzeugBase fahrzeug = new FahrzeugBase();
            fahrzeug.Baujahr = 1999;
            fahrzeug.Marke = "BMW";
            fahrzeug.Modell = "Z8";
            fahrzeug.MaxGeschwindigkeit = 250;


            FahrzeugBase auto = new FahrzeugBase(1999, "BMW", "Z8", 250);

            FahrzeugBase autoVersion2 = new FahrzeugBase(2020, "Fiat", "Punto", 280, "Blau");

            autoVersion2.StarteMotor();
            autoVersion2.Beschleunigung(150);
            Console.WriteLine(autoVersion2.Display());
            autoVersion2.Beschleunigung(150);
            Console.WriteLine(autoVersion2.Display());


           
            //FahrzeugBase autoVersion3 = new FahrzeugBase(2019, "Fiat", "Punto", 130, "Blau");
            //FahrzeugBase autoVersion4 = new FahrzeugBase(2018, "BMW", "Z8", 220, "Rot");
            //FahrzeugBase autoVersion5 = new FahrzeugBase(2017, "Porsche", "xyz", 280, "Schwarz");
            //FahrzeugBase autoVersion6 = new FahrzeugBase(2016, "Audi", "Quatro", 240, "Sibler");


            FahrzeugBase.KmhToMph("123");


            Yacht yacht = new Yacht(2010, "DagobertDuckWerft", "Yacht 1.0", 20, "Blau", 1.2, true);

            yacht.AnkerAuswerfen();
            yacht.MakeParty();


            yacht.WartungsArbeitenInTage(); // bekomme 10 

            Console.WriteLine(yacht.ToString());

            ContainerSchiff containerSchiff = new ContainerSchiff(1990, "Kühne Werft", "Blub Blub 1.0", 5, "grau", 2, 100,20);
            containerSchiff.AnkerAuswerfen();
            containerSchiff.BeladeSchiff(50);


            BobbyCar orginalBobbyCar = new BobbyCar("Toy1.0", "Model123", 2019, 1, "rot", 50);


            //Eine neue Kopie wird übergeben. Neuer Speicherbereich
            BobbyCar kopiertesBobbyCar = (BobbyCar)orginalBobbyCar.Clone();

            //Speicheradresse wird hier übergeben 
            BobbyCar weitereKopieBobbyCar = orginalBobbyCar;


            ChangeBobyCar(kopiertesBobbyCar);
            ChangeBobyCar(weitereKopieBobbyCar);

            Console.WriteLine(orginalBobbyCar.Farbe);
            Console.ReadKey();




        }



        static void ChangeBobyCar(BobbyCar car)
        {
            car.Farbe = "Blau";
        }
    }
}
