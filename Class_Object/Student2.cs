using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Student2
    {


        private int rollno;
        private String name;
        private double percentage;



        public int RollNO
        {
            set { rollno = value; }
            get { return rollno; }
        
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        
        }

        public double Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        
        }

        public String Print()
        {

            return $" {rollno} ,{name}, {percentage}";
        
        }


    }
}
