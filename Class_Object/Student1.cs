using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public  class Student1
    {
        private int rollno;
        private String name;
        private int m1, m2, m3, total;
        private double percentage;


        public Student1()
        {

            int rollno = 0;
            String name = "";
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int total = 0;
            double percentage = 0.0;
        }
        public Student1(int rollno,String name,int m1,int m2,int m3)
        { 
           this.rollno=rollno;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;

        
        
        }
        public void calculte()
        {

            total = m1 + m2 + m3;
            percentage = total / 3;
        
        
        }
        public String Disply()
        {
            return $"  rollno={rollno} name={name} total={total} percentage ={percentage}";
        
        
        }



    }
}
