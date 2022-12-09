using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienRestaurant
{
    internal class BunArea
    {
        
        public void OrderBun(string type)
        {
            Bun aBun;
            switch (type)
            {
                case "bun gio":
                    Console.WriteLine($"Successfully!! You orderred 1 {type}");
                    aBun = new BunGio();
                    break;
                case "bun bo":
                    Console.WriteLine($"Successfully!! You orderred 1 {type}");
                    aBun = new BunBo();
                    break;
                default:
                    Console.WriteLine($"Oops! We don't have {type}");
                    return;
            }
            aBun.Prepare();
            aBun.Cook();
            aBun.Add();
            aBun.Mix();

        }
    }
}
