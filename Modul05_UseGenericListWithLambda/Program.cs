using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_UseGenericListWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            peopleList.Add(new Person { Vorname = "Max", Nachname = "Mustermann", Height = 177 });
            peopleList.Add(new Person { Vorname = "Maxi", Nachname = "Mustermann", Height = 177 });
            peopleList.Add(new Person { Vorname = "Meika", Nachname = "Mustermann", Height = 183 });
            peopleList.Add(new Person { Vorname = "Steffi", Nachname = "Mustermann", Height = 171 });
            peopleList.Add(new Person { Vorname = "Monika", Nachname = "Mustermann", Height = 182 });
            peopleList.Add(new Person { Vorname = "Hebert", Nachname = "Mustermann", Height = 160 });
            peopleList.Add(new Person { Vorname = "Harald", Nachname = "Mustermann", Height = 181 });
            peopleList.Add(new Person { Vorname = "Kevin", Nachname = "Mustermann", Height = 150 });



            List<Person> ergebnis1 = peopleList.Where(n => n.Height > 170).OrderByDescending(n => n.Height).ToList();
                                                
            Console.WriteLine("Gebe alle PErsonen aus die größer als 170cm sind");

            foreach (Person p in ergebnis1)
                Console.WriteLine($"{p.Vorname} {p.Nachname} {p.Height}");


            int gesamtgroßeAllerPersonen = peopleList.Sum(n => n.Height);
            Console.WriteLine(gesamtgroßeAllerPersonen.ToString());


            Person gesuchtePerson = peopleList.Single(n => n.Vorname == "Kevin");
            Console.WriteLine(gesuchtePerson.Vorname + " " + gesuchtePerson.Nachname );



            Person großtePerson = peopleList.Where(n => n.Height > 180).OrderByDescending(n => n.Height).First();
            Console.WriteLine($"Größte Person ist: {großtePerson.Vorname} {großtePerson.Nachname} {großtePerson.Height}");

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Height { get; set; }
    }
}
