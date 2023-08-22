using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public  class Product1
    {
        private int code;
        private string name;
        private double price;



        //public int Code
        //{
        //    set { code= value; }
        //    get { return code; }

        //}
        //public String Name
        //{
        //    set { name = value; }
        //    get { return name; }

        //}
        //public double Price
        //{
        //    set { price = value; }
        //    get { return price; }

        //}


        //Auto Implemented properties
        public int Code
        { 
            set { code = value; }
            get { return code; } 
        
        }
        public String Name 
        { 
            set { name = value; }
            get { return name; }
        
        }
        public double Price
        { 
            set { price = value; }
            get { return price; }
        
        }

        public String Show()
        {
            return $"{code},{name},{price}";
        
        }




    }
}
