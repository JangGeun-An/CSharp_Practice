using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{
    internal class Animal
    {
        public int Age { get; set; }
        public SexEnum Sex { get; set; }
        public int Weight { get; set; }

        /*public Animal() 
        {
            System.Console.WriteLine("Animal " + this.ToString());
        }*/

        public void Sleep()
        {
            Console.WriteLine("I'm sleeping now");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating banana");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking road");
        }

        public override string ToString()
        {
           return "I'm an Animal";
        }
    }
}
