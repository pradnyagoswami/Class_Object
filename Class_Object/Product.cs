using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Product
    {
        private int id;
        private double price;
        private String name;


        public Product()
        {

            int id = 0;
            double price = 0.0;
            String name = "";
            }
            public Product(int id,double price,String name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }
        public String Discount(double disprice)
        {
            price = price - ((price / 100) * disprice);
            return $"id={id} price={price} name={name}"; ;
        
        }
        public String Disply()
        {

            return $"Before Discount id={id} price={price} name={name}";
            
        
        }





    }
}
