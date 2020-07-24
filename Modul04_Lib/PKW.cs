using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class PKW : FahrzeugBase, IFahrlizenz
    {
        public PKW(string marke, string modell, int baujahr, double maxGeschw, string farbe, int anzahlTueren, int anzahlRaeder)
            : base(baujahr, marke, modell, maxGeschw,farbe)
        {
            this.AnzahlRader = anzahlRaeder;
            this.AnzahlTueren = anzahlTueren;
        }

        public int AnzahlRader { get; set; }
        public int AnzahlTueren { get; set; }

        public int FahrlizenzAbWievielenJahren()
        {
            return 17;
        }
    }

    public class BobbyCar : FahrzeugBase, ICloneable
    {
        public BobbyCar()
        {

        }

        public BobbyCar(string marke, string modell, int baujahr, double maxGeschw, string farbe, int maxGewicht)
            : base(baujahr, marke, modell, maxGeschw, farbe)
        {
            
        }






        public object Clone()
        {
            BobbyCar bobbyCar = new BobbyCar();
            bobbyCar.Modell = this.Modell;
            bobbyCar.Marke = this.Marke;
            bobbyCar.MaxGeschwindigkeit = this.MaxGeschwindigkeit;
            bobbyCar.AktGeschwindigkeit = this.AktGeschwindigkeit;
            bobbyCar.Farbe = this.Farbe;
            bobbyCar.MotorLaeuft = this.MotorLaeuft;
            bobbyCar.Baujahr = this.Baujahr;


            return bobbyCar;
        }
    }
}
