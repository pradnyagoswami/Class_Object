using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Object
{
    public class Student3
    {
        //3. create another method in Student class setCustomData(int  customId, String customName) These 2 variables are local variables.Call setCustomData from main method using
        //Student object and assign any values to customId, customName from main method.Observe your values are overwritten in id and name instance variables.Then print id and name in main method.


        private int customID;
        private String CustomName;

        public void SetCustomData(int customId,String customName)
        {
            customID = 101;
           CustomName = "Pooja";
        
        
        }



        static void Main(string[] args)
        { 
        
        
        }






































































    }
}
