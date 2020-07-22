﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class Fahrzeug
    {

        //in C++ ist der Stil so -> private int m_baujahr; 
        //in C# kommt diese Variante auch oft vor -> private int _baujahr; 


        private int baujahr; 
        private string marke;
        private string modell;

        private double aktGeschwindigkeit;
        private double maxGeschwindigkeit;


        // AutoProperty -> Member-Variable wird zur Laufzeit angelegt und von der AutoProperty verwendet.
        public bool MotorLäuft { get; set; }

        public string Farbe { get; set; }




        //DEfault Konstruktor mit Standard-Werte
        public Fahrzeug()
        {

            if (AnzahlErstellterFahrzeuge <= MaxAnzahlErstellterFahrzeuge)
            {
                AktGeschwindigkeit = 0;
                MotorLäuft = false;

                AnzahlErstellterFahrzeuge++;
            }
            else
                throw new Exception("Es gibt zuviele Fahrzeuge, der Arbeitsspeicher reicht dafür nicht aus");

            
        }

        //Konstruktor für benutzerdefinierte Angaben -> BMW, Audi...etc
        public Fahrzeug(int baujahr, string marke, string modell, double maxGeschwindigkeit)
            :this()
        {
            Baujahr = baujahr;
            Marke = marke;
            Modell = modell;
            MaxGeschwindigkeit = maxGeschwindigkeit;
        }

        //Konstruktor für Version 2.0 unseres Fahrzeuges
        public Fahrzeug(int baujahr, string marke, string modell, double maxGeschwindigkeit, string farbe)
            : this(baujahr, marke, modell, maxGeschwindigkeit)
        {
            this.Farbe = farbe;
        }




        #region Schlechter Stil -> wurde früher in C/C++ angewendet
        public void SetBaujahr(int baujahr)
        {
            this.baujahr = baujahr;
        }

        public int GetBaujahr()
        {
            return baujahr;
        }
        #endregion

        #region Properties
        public int Baujahr
        {
            get
            {
                return baujahr;
            }

            set
            {
                // Mit Properties kann man im Set-Accessor eine Validierung durchführen. Wenn der zugewiesene Eintrag valide ist
                // dann wird auch der Wert auf die Variable baujahr zugewiesen. 
                if (value > 1899 && value < 2021)
                {
                    baujahr = value;
                }
                else
                    throw new ArgumentException();
            }
        }

        public string Marke
        {
            get
            {
                return marke;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    marke = value;
            }
        }

        public string Modell
        {
            get
            {
                return modell;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    modell = value;
            }
        }

        public double AktGeschwindigkeit //Ausgeschriebene Form von Properties (hier kann man mehrere Zeilen an Validierung reinnehmen
        {
            get
            {
                return aktGeschwindigkeit;
            }

            set
            {
                aktGeschwindigkeit = value;
            }
        }
        public double MaxGeschwindigkeit { get => maxGeschwindigkeit; set => maxGeschwindigkeit = value; } //Kurzform von Properties


        #endregion

        #region Methoden

        public void StarteMotor()
        {
            MotorLäuft = true;
        }

        public void StoppeMotor()
        {
            MotorLäuft = false;
        }

        public void Beschleunigung(int a)
        {
            if(MotorLäuft == true)
            {

                if (AktGeschwindigkeit + a > MaxGeschwindigkeit)
                {
                    AktGeschwindigkeit = MaxGeschwindigkeit;
                }
                else if (AktGeschwindigkeit + a < 0)
                {
                    AktGeschwindigkeit = 0;
                }
                else
                    AktGeschwindigkeit += a;
            }
        }

        public bool MussFahrzeugZumTüv()
        {
            if (!DateTime.IsLeapYear(Baujahr))
                return false;

            return true;
        }

        public string  Display()
        {
            return $"Marke: {Marke} - Modell: {Modell} - Baujahr: {Baujahr} - Höchsgeschwindigkeit: {MaxGeschwindigkeit} - Aktuelle Geschwindigkeit: {AktGeschwindigkeit}";
        }

        #endregion




        public static double KmhToMph(double kmh)
        {
            return 0.6214 * kmh;
        }

        public static double MphToKmh(double mph)
        {
            return mph * 1.60934;
        }


        public static int AnzahlErstellterFahrzeuge { get; private set; } = 0;

        public static int MaxAnzahlErstellterFahrzeuge { get; private set; } = 5;
    }
}
