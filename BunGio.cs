using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienRestaurant
{
    internal class BunGio : Bun //Inheritance
    {
        public BunGio()
        {
            name = "Bun gio";
            bowl = "To size M";
            meats.Add("Giò Heo"); 
        }
        public override void Prepare() // abstract method
        {
            Console.WriteLine($"Preparing {name}");
        }
    }

}
