using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public  class Employee
    {

        private int id;
        private string name;
        private String department;
        private double salary,hra,da,ta,pf,gross;
        private static int count;
       // private static int Countemp;







        public Employee()
        {

            int id = 0;
            String name = "";
            String department = "";
            double salary = 0.0;
        
        }

        public Employee(int id,String name,String department,double salary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.department = department;
            this.salary = salary;
        
        }
        public static int GetcountEmp()
        {
            return count;
        
        }

        public void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + ta + da) - pf;
        
        
        }


        public String Disply()
        {
            return $"Employee: id of employee = {id}\n name of Employee = {name}\n Employee department = {department}\n Employee salary = {salary}\ngross={gross}";
        
        }




    }
}
