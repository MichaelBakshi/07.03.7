using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._7
{
    public class Kitchen
    {
        public event EventHandler<DishEventArgs> DishReady;

        public void PrepareDish()
        {
            Console.WriteLine("Preparing dish");
            OneDishReady(new DishEventArgs { 
                DishName = "sushi"
            });
        }
        
        public  void OneDishReady (DishEventArgs e)
        {
            if (DishReady!=null)
            { 
                DishReady.Invoke(this, e);
            }
        }
       
    }
}
