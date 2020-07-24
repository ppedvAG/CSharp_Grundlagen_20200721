using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_WdhVererbungAbstractVirtualPoly
{


    public abstract class Tier
    {
        // public int Alter {get;set;}

        // public bool IsGesund {get;set}

        // public int Gewicht {get;set;}

        public int AnzahlBeine { get; set; }

        public string Name { get; set; }

        public Tier(string name, int anzB)
        {
            this.AnzahlBeine = anzB;
            this.Name = name;
        }

        public abstract void Fressen();
    }

    public class Hund : Tier
    {

        public string Fellfarbe { get; set; }

        public Hund(string name, string fellFarbe) : base(name, 4)
        {
            this.Fellfarbe = fellFarbe;
        }

        public override void Fressen()
        {
            Console.WriteLine("Der Hund frisst ein Stück Fleisch.");
        }

        public override string ToString()
        {
            return $"{Name} geht es gut";
        }
    }

    public class Meise : Tier, IFlugfähig
    {
        public string Federfarbe { get; set; }

        public int FlügelAnzahl { get; set; }

        public Meise (string name, string federFarbe) : base (name, 2)
        {
            this.Federfarbe = federFarbe;
            this.FlügelAnzahl = 2;
        }

        public override void Fressen()
        {
            Console.WriteLine("Die Meise pickt Körner");
        }

        public void Abheben()
        {
            Console.WriteLine("Dies Meise fliegt jetzt.");
        }
    }


    public class Flugzeug : IFlugfähig
    {
        public int MaxFlughöhe { get; set; }
        public int FlügelAnzahl { get; set; }

        public Flugzeug(int flügelAnzahl)
        {
            this.MaxFlughöhe = 9999;
            this.FlügelAnzahl = flügelAnzahl;
        }

        public void Abheben()
        {
            Console.WriteLine("Flugzeug hebt ab");
        }
    }

    public interface IFlugfähig
    {
        int FlügelAnzahl { get; set; }

        void Abheben();
    }

    public interface IRaumfahrtFähig
    {
        void Abheben();
    }


    class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund("Bello", "Braun");
            Console.WriteLine(hund1.ToString());
            Console.WriteLine(hund1.Name + ": " + hund1.Fellfarbe);

            Meise meise1 = new Meise("Tschiep", "Blau");
            Console.WriteLine(meise1.Name + ": " + meise1.Federfarbe);

            BenneUm(meise1, "PiepPiep");
            BenneUm(hund1, "Hasso");

            Console.ReadKey();


            #region weiteres Beispiel für Polym.

            Hashtable htable = new Hashtable();

            ArrayList arrayList = new ArrayList();
            arrayList.Add(meise1);



            Meise meise2;
            if (arrayList != null)
            {
                if (arrayList.Count > 0)
                {
                    if (arrayList[0] is Meise)
                        meise2 = (Meise)arrayList[0];


                    if (arrayList[0] is string)
                    {

                    }

                    if (arrayList[0] is DateTime)
                    {

                    }

                    if (arrayList[0] is Console)
                    {

                    }
                }
            }

            

            List<Tier> tierList = new List<Tier>();
            tierList.Add(meise1);

            if (tierList[0] is Meise)
                meise2 = (Meise)tierList[0];
            else if (tierList[0] is Hund)
                hund1 = (Hund)tierList[0];
            else
                throw new Exception("unbekanntes Objekt");








            #endregion


            Flugzeug fz1 = new Flugzeug(4);

            Absturz(fz1);
            Absturz(meise1);

            //Dependency Injections
            IFlugfähig flugfähig = meise1;

            Absturz(flugfähig);


            List<Flugzeug> flugzListe = new List<Flugzeug>();


            IList<Flugzeug> flugzeugListe1 = new List<Flugzeug>();

            InventarListe(flugzeugListe1);

        }

        static void InventarListe (IList<Flugzeug> liste)
        {

        }

        static void BenneUm(Tier tier, string neuerName)
        {
            tier.Name = neuerName;


            if (tier is Hund)
                ((Hund)tier).Fellfarbe = "schwarz"; //traditionelle konventierung
            else if (tier is Meise)
                (tier as Meise).FlügelAnzahl = 1; //mit direkter konventierung
        }
        
        static void Absturz (IFlugfähig flugfähigesObjekt)
        {
            flugfähigesObjekt.FlügelAnzahl--;

            if (flugfähigesObjekt is Flugzeug)
                ((Flugzeug)flugfähigesObjekt).MaxFlughöhe = 0;

        }
    }
}
