using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._7
{
     class Waiter
    {
        public  void OneDishReady(object sender, DishEventArgs e)
        {
            Console.WriteLine($"Serving the dish {e.DishName} to the customers");
        }
    }
}
