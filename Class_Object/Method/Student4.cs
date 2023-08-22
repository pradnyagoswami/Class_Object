using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object.Method
{
    public class Student4
    {
        //1. add method displayData inside Student class change values of id name in that method & also print the changed values in same method.
        //Call displayData method from main method and see the output.Observe displayData can only be called by creating object of Student



        private int id;
        private String name;



        public Student4(int id, String name)
        {
            this.id = id;
            this.name = name;

        }
        public String DisplyData()
        {
            id = 101;
            String name = "sita";

            return $"{id},{name}";

        }

        static void Main(String[] args)
        {
            Student4 s = new Student4(101, "pradnya");
            s.DisplyData();



        }

    }

     
}
