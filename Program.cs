using System;
using System.Collections.Generic;
namespace ThienRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bunArea = new BunArea();
            Console.WriteLine("What's Bun you wanna order?");
            string type = Console.ReadLine();
            bunArea.OrderBun(type);
        }
    }
}