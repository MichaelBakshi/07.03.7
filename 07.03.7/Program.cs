using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._7
{
    class Program
    {

        //public delegate void EventHandler(object sender, EventArgs e);

        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Waiter waiter = new Waiter();
            kitchen.DishReady += waiter.OneDishReady;
            kitchen.PrepareDish();
        }
    }
}
