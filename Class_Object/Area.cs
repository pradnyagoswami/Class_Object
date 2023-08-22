using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Area
    {

        private int radius;
        private int length, breadth, height;
        private double pi;



        public void Accept(int radius, int length, int breadth, int height)
        {
            this.radius = radius;
            this.length = length;
            this.breadth = breadth;
            this.height = height;

        }

        public double AreaofCircle()
        {
            return  pi * radius * radius;


        }
        public int AreaofRectAngle()
        {

            return length * breadth;
        
        }
        public String show()
        {

            return $"";
        
        }





    }
   

}
