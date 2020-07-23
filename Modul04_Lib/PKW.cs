using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class PKW : FahrzeugBase
    {
        public PKW(string marke, string modell, int baujahr, double maxGeschw, string farbe, int anzahlTueren, int anzahlRaeder)
            : base(baujahr, marke, modell, maxGeschw,farbe)
        {
            this.AnzahlRader = anzahlRaeder;
            this.AnzahlTueren = anzahlTueren;
        }

        public int AnzahlRader { get; set; }
        public int AnzahlTueren { get; set; }

    }

    public class BobbyCar : FahrzeugBase
    {
        public BobbyCar()
        {

        }

        public BobbyCar(string marke, string modell, int baujahr, double maxGeschw, string farbe, int maxGewicht)
            : base(baujahr, marke, modell, maxGeschw, farbe)
        {
            this.MaxGeschwicht = maxGewicht;
        }


        public int MaxGeschwicht { get; set; }

        //public object Clone()
        //{
        //    BobbyCar bobbyCar = new BobbyCar();
        //    bobbyCar.Modell = this.Modell;
        //    bobbyCar.Marke = this.Marke;
        //    bobbyCar.MaxGeschwicht = this.MaxGeschwicht;
        //    bobbyCar.AktGeschwindigkeit = this.AktGeschwindigkeit;
        //    bobbyCar.Farbe = this.Farbe;
        //    bobbyCar.MotorLaeuft = this.MotorLaeuft;
        //    bobbyCar.Baujahr = this.Baujahr;


        //    return bobbyCar;
        //}
    }
}
