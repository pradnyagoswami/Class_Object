using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Student
    {
        private int rollno;
        private string name;
        private double total,m1,m2,m3,percentage;
        private String grade;




        public Student()//parameter less constructor
        {
             rollno = 0;
             name = " ";
             percentage = 0.0;
            total = 0.0;
            m1 = 0.0;
            m2 = 0.0;
            m3 = 0.0;
            grade = "";


             
        }

        public Student(int rollno,String name,double m1,double m2,double m3,string grade)//parametric constructor
        { 
            this.rollno = rollno;
            this.name = name;
            this.percentage = percentage;
            this.total = total;
            this.m1= m1;    
            this.m2 = m2;
            this.m3= m3;    
            this.grade = grade;
            
        
        
        }

        public void Calculate()
        {

            total = m1 + m2 + m3;
            percentage = total / 3;
            
        
        
        }
        public void grades()
        {
            if (percentage > 90)
            {
                Console.WriteLine("A grade");

            }
            else if (percentage > 80)
            {

                Console.WriteLine("B grade");

            }
            else if (percentage>70)
            {
                Console.WriteLine("C grade");

            }
        
        
        
        }
        public String Disply()
        {

            return $"Student :  student name is = {name}\n  percentage={percentage}";

        }



    }
}
