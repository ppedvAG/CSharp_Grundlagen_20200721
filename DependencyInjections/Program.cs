using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjections
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ICar dasAuto = new MockCar(); // -> Testdaten für die Entwicklung

            ICar dasProduktiveObject = new Car();


            ICarService carService = new CarService();
            carService.Repariere(dasProduktiveObject);


        }
    }

    #region Schlechtes Beispiel //Mitarbeiter 2 Backend //Lange Entwicklungzeit
    public class BadCar
    {
        public string Modell { get; set; }
    }

    public class BadCarService // Mitarbeiter 1 //Sevice Layer
    {
        public void Repariere(BadCar car)
        {
            
            //Repariere auto 
        }
    }

    #endregion


    #region Dependency Beispiel
    public interface ICar
    {
        string Modell { get; set; }
    }

    public class Car : ICar // Mitarbeiter 1 - Backend - arbeite hier sehr lange
    {
        public string Modell { get; set; }
    }

    public class MockCar : ICar
    {
        public MockCar()
        {
            Modell = "BMW";
        }

        public string Modell { get; set; }
    }

    public interface ICarService
    {
        void Repariere(ICar car);

        int ReperaturDauer();
    }


    public class CarMockService : ICarService
    {
        public void Repariere(ICar car)
        {
            throw new NotImplementedException();
        }

        public int ReperaturDauer()
        {
            return 5;
        }
    }

    public class CarService : ICarService //Mitarbeiter 2..braucht eigentlich ein Car-Object mit Testwerten
    {
        ICar _car;
        public void Repariere(ICar car)
        {
            //ICar wird repariert
            _car = car;
        }

        public int ReperaturDauer()
        {
            if (_car.Modell == "Trappi")
            {
                return 10;
            }
            else if (_car.Modell == "BMW")
            {

                return 1;
            }
            else return 2;
        }
    }

    #endregion




}
