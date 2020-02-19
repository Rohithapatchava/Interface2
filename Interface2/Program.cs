using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        class Bike
        {
            public  void Mymethod()
            {
                Console.WriteLine("hello");
            }
            public void show()
            {
                Console.WriteLine("people");
            }
    }
        interface Idrone
        {
            void myOthermethod();
            void show();
        }
        class BikeDrone:Bike,Idrone
        {
            
            
            public void myOthermethod()
            {
                Console.WriteLine("good morning");
            }
            public void show()
            {
                Console.WriteLine("welcoime all");
            }
        }
        static void Main(string[] args)
        {
            BikeDrone b = new BikeDrone();
            Bike b1 = new Bike();
            b.Mymethod();
            b.myOthermethod();
            b.show();
            b1.show();
        }
    }
}
