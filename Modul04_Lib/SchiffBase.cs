using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class SchiffBase : FahrzeugBase
    {
         
        public SchiffBase (int baujahr, string marke, string modell, double maxGeschwindigkeit, string farbe, double tiefgang)
            :base(baujahr, marke, modell, maxGeschwindigkeit, farbe)
        {
            this.Tiefgang = tiefgang;
        }

        public double Tiefgang { get; set; }
        public bool IsAnchorInUse { get; set; }
        
        public void AnkerEinziehen ()
        {
            IsAnchorInUse = false;
        }

        public void AnkerAuswerfen ()
        {
            IsAnchorInUse = true;
        }

        //public override int WartungsArbeitenInTage()
        //{
        //    return 20;
        //}
    }


    public class Yacht : SchiffBase
    {
        public Yacht (int baujahr, string marke, string modell, double maxGeschwindigkeit, string farbe, double tiefgang, bool pool)
            :base(baujahr, marke, modell, maxGeschwindigkeit, farbe, tiefgang)
        {
            this.Pool = pool;
        }
        public bool Pool { get; set; }

        public void MakeParty()
        {
            //Party auf dem Boot
        }

        public override int WartungsArbeitenInTage()
        {
            return 7;
        }

        public override string ToString()
        {
            return base.ToString() + " - Ich bin allerdings eine Yacht!";
        }
    }


    public class Tretboot : SchiffBase
    {
        public Tretboot(int baujahr, string marke, string modell, double maxGeschwindigkeit, string farbe, double tiefgang, int personenAnzahl) 
            : base(baujahr, marke, modell, maxGeschwindigkeit, farbe, tiefgang)
        {
            this.Personenanzahl = personenAnzahl;
        }

        public int Personenanzahl { get; set; }

        public int LeihzeitInMinuten { get; set; }

        public bool MussIchZurueckFahren()
        {
            if (LeihzeitInMinuten < 5)
            {
                //Fahre zurück zum Steg
                return true;
            }


            return false;
        }

        public override int WartungsArbeitenInTage()
        {
            return 1;
        }

    }

    public class ContainerSchiff : SchiffBase
    {
        public ContainerSchiff(int baujahr, string marke, string modell, double maxGeschwindigkeit, string farbe, double tiefgang, int maxLadeMenge, int aktuelleLadeMenge) 
            : base(baujahr, marke, modell, maxGeschwindigkeit, farbe, tiefgang)
        {
            this.LademengeInTonnenMax = maxLadeMenge;
            this.AktuelleLademengeInTonnen = aktuelleLadeMenge;
        }

        public int LademengeInTonnenMax { get; set; }

        public int AktuelleLademengeInTonnen { get; set; }
        public void BeladeSchiff(int Lademenge)
        {
            if (AktuelleLademengeInTonnen + Lademenge > LademengeInTonnenMax)
                AktuelleLademengeInTonnen = LademengeInTonnenMax;
            else if (AktuelleLademengeInTonnen + Lademenge < 0)
                AktuelleLademengeInTonnen = 0;
            else
                AktuelleLademengeInTonnen += Lademenge;
        }


        public override int WartungsArbeitenInTage()
        {
            return 50;
        }

        
    }

}
