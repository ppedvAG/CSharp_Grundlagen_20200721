using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_VirtualProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            //Am besten mit Debugger einmal durchlaufen lassen 
            MyBaseClass baseClass = new MyBaseClass();
            baseClass.Name = string.Empty;

            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.Name = string.Empty ;


            MyDerivedClass myDerivedClass1 = new MyDerivedClass();
            myDerivedClass.Name = "Max Mustermann";


            Console.ReadKey();

        }
    }




    public class MyBaseClass
    {
        // virtual auto-implemented property. Overrides can only
        // provide specialized behavior if they implement get and set accessors.
        public virtual string Name { get; set; }

        // ordinary virtual property with backing field
        private int num;
        public virtual int Number
        {
            get { return num; }
            set { num = value; }
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        private string name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "Unknown";
                }
            }
        }
    }
}
