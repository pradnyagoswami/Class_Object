using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object.Method
{
    public class Student5
    {
        //2. Create getId() method in Student class. call getId() method from displayData method so that you know that one method can be called from another method.Return id
        //from getId() method and set that id to the instance variable in displayData method.

        private int id;
        private String name;



        public int GetId()
        {

            int id = 101;
            String name = "raj";
            return id;

        }
        public void Displydata()
        {
            this.id = this.GetId();
            Console.WriteLine(id);

        }

        static void Main(string[] args)
        {
            Student5 student = new Student5();  
            student.Displydata();




        }




    }
    
}
