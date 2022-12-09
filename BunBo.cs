using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienRestaurant
{
    internal class BunBo : Bun //Inheritance
    {
        public BunBo()
        {
            name = "Bun Bo"; //Encapsulation
            bowl = "Tô size M";
            meats.Add("Thit Bo");
        }
        public override void Prepare()
        {
                Console.WriteLine($"Preparing {name}");
        }
        public override void Add() //Polymorphism
        {
            base.Add();
            string chili = "a Chili";
            Console.WriteLine($"Adding {chili} to {bowl}");
        }

    }
}
