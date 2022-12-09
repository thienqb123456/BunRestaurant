using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienRestaurant
{
    public abstract class Bun //Abstraction
    {
        protected string name; //Encapsulation
        protected string bowl; 
        protected string soiBun = "Soi Bun Gao";
        protected string nuocLeo = "Nuoc Ham xuong dac biet";
        protected List<string> meats = new List<string>();

        public abstract void Prepare(); // Abstract method

        public void Cook()
        {
            Console.WriteLine($"Cooking {nuocLeo}");
            meats.ForEach((meat) => Console.WriteLine($"Cooking {meat}"));
        }

        public virtual void Add() // Polymorphism
        { 
            Console.WriteLine($"Adding {soiBun} to {bowl}");
            meats.ForEach((meat) => Console.WriteLine($"Adding {meat} to {bowl}"));
        }
        public void Mix()
        {
            Console.WriteLine($"Mixing {soiBun} & {nuocLeo} together!!");
        }
    }
}
