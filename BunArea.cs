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
                    aBun = new BunGio();
                    
                    break;
                case "bun bo":
                    aBun = new BunBo();
                    break;
                default:
                    Console.WriteLine($"We don't have {type}!!");
                    return;
            }
            aBun.Prepare();
            aBun.Cook();
            aBun.Add();
            aBun.Mix();

        }
    }
}
