using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_UseGenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            BeispielKlasse beispielKlasse = new BeispielKlasse();


            //ARRAY von 10 Elementen. Könnte man als Liste verwenden 
            BeispielKlasse[] beispielKlassesArry = new BeispielKlasse[10];
            beispielKlassesArry[0] = new BeispielKlasse{ Name = "ABC"};

            List<BeispielKlasse> beispielKlassenListe = new List<BeispielKlasse>();

            beispielKlassenListe.Add(new BeispielKlasse { Name = "123" });
            beispielKlassenListe.Add(new BeispielKlasse { Name = "456" });
            beispielKlassenListe.Add(new BeispielKlasse { Name = "abc" });
            beispielKlassenListe.Add(new BeispielKlasse { Name = "def" });

            //Hier wird 4 ausgegeben
            Console.WriteLine($"{beispielKlassenListe.Count}");
            //Index Funktionalität 0-3
            BeispielKlasse selectedBeispielKlasse = beispielKlassenListe[0];

            foreach (BeispielKlasse currentBeispielKlasse in beispielKlassenListe)
            {
                Console.WriteLine(currentBeispielKlasse.Name);
            }

            beispielKlassenListe[1].Name = "Franz Beckenbauer";


            foreach (BeispielKlasse currentBeispielKlasse in beispielKlassenListe)
            {
                Console.WriteLine(currentBeispielKlasse.Name);
            }

            beispielKlassenListe.RemoveAt(3);
            foreach (BeispielKlasse currentBeispielKlasse in beispielKlassenListe)
            {
                Console.WriteLine(currentBeispielKlasse.Name);
            }
            Console.ReadKey();



            Console.WriteLine("Stack<T> Beispiel: ");


            Stack<BeispielKlasse> beispielStack = new Stack<BeispielKlasse>();
            beispielStack.Push(new BeispielKlasse { Name = "123" });
            beispielStack.Push(new BeispielKlasse { Name = "345" });
            beispielStack.Push(new BeispielKlasse { Name = "678" });
            beispielStack.Push(new BeispielKlasse { Name = "abc" });
            beispielStack.Push(new BeispielKlasse { Name = "def" });
            Console.WriteLine($"Elemente im Stack-Speicher: {beispielStack.Count}");

            BeispielKlasse beispielKlasse1 = beispielStack.Peek();
            Console.WriteLine($"Nach Peek-Operation {beispielKlasse1.Name}"); //def
            Console.WriteLine($"Elemente im Stack-Speicher: {beispielStack.Count}"); //5


            BeispielKlasse beispielKlasse2 = beispielStack.Pop();
            Console.WriteLine($"Nach Pop-Operation {beispielKlasse2.Name}"); //def
            Console.WriteLine($"Elemente im Stack-Speicher: {beispielStack.Count}"); //4


            BeispielKlasse beispielKlasse3 = beispielStack.Pop();
            Console.WriteLine($"Nach Pop-Operation {beispielKlasse3.Name}"); //abc
            Console.WriteLine($"Elemente im Stack-Speicher: {beispielStack.Count}"); //3

            Console.ReadKey();
            Console.WriteLine("Queue BEispiel");
            Queue<BeispielKlasse> beispielQueue = new Queue<BeispielKlasse>();
            beispielQueue.Enqueue(new BeispielKlasse { Name = "123" });
            beispielQueue.Enqueue(new BeispielKlasse { Name = "345" });
            beispielQueue.Enqueue(new BeispielKlasse { Name = "678" });
            beispielQueue.Enqueue(new BeispielKlasse { Name = "abc" });
            beispielQueue.Enqueue(new BeispielKlasse { Name = "def" });
            Console.WriteLine($"Elemente im Stack-Speicher: {beispielQueue.Count}");

            BeispielKlasse beispielKlasse4 = beispielQueue.Peek(); //123
            Console.WriteLine($"Elemente im Queue-Speicher: {beispielQueue.Count}"); //5

            BeispielKlasse beispielKlasse5 = beispielQueue.Dequeue(); //123
            Console.WriteLine($"Elemente im Queue-Speicher: {beispielQueue.Count}"); //4

            Console.ReadKey();






            Dictionary<string, Fahrzeug> AutoNummernSchilderRegister = new Dictionary<string, Fahrzeug>();

            AutoNummernSchilderRegister.Add("BVB123", new Fahrzeug { Name = "Audi" });
            AutoNummernSchilderRegister.Add("MUC456", new Fahrzeug { Name = "BMW" });
            AutoNummernSchilderRegister.Add("STU789", new Fahrzeug { Name = "BMW" });


            //Gibt es die Nummernschild-Beziechnung in unserem Register
            if (AutoNummernSchilderRegister.ContainsKey("BVB123"))
            {
                Fahrzeug fahrzeug = AutoNummernSchilderRegister["BVB123"];
               
            }

            //Beim Hinzufügen, müssen wir prüfen, dass das Nummernschild einmalig ist

            if (!AutoNummernSchilderRegister.ContainsKey("FFM123"))
            {
                AutoNummernSchilderRegister.Add("FFM123", new Fahrzeug { Name = "Mazda" });
                AutoNummernSchilderRegister.Add("FFM123", new Fahrzeug { Name = "Mazda" });
            }


            foreach (KeyValuePair<string, Fahrzeug> aktuellerEintrag in AutoNummernSchilderRegister)
            {
                Console.WriteLine($"Key: {aktuellerEintrag.Key} - Value: {aktuellerEintrag.Value}");
            }



            Console.ReadKey();
            Hashtable hashtable = new Hashtable();


            hashtable.Add(1, "hallejulia");
            hashtable.Add(DateTime.Now, 12345);




            


        }
    }


    public class Fahrzeug
    {
        public string Name { get; set; }
    }


    public class BeispielKlasse
    {
        public string Name { get; set; }
    }
}
