using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Practice
{
    internal class Supermarket
    {
        List<Product> products = null;
        public Supermarket()
        {
            products = new List<Product>();
            products.Add(new Product { Price = 1000, Category = 1});
            products.Add(new Product { Price = 1000, Category = 1 });
            products.Add(new Product { Price = 1000, Category = 1});
        }

        public double this[int category] 
        {  
            get 
            { 
                TimeSpan starttime = new TimeSpan(8, 0, 0);
                TimeSpan endtime = new TimeSpan(12, 0, 0);

                var time = DateTime.Now.TimeOfDay;
                double sum = 0.0;
                foreach (Product item in products)
                {
                    sum += item.Price;
                }
                if (time >= starttime && time <= endtime)
                {              
                    return sum * 0.95;
                }
                else
                {
                    return sum;
                }

            } 
        
        }
    }
}
