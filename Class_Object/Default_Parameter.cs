using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Default_Parameter
    {
        private String companyName, ModelName;
        private int cost;


        public Default_Parameter(String companyName,int cost, String ModelName="Hyundai")
        { 
        
            this.companyName = companyName;
            this.cost = cost;
            this.ModelName = ModelName;
        
        
        }

        public void Accept(String ModelNAme, String companyName="toyota")
        { 
        
        }
        public String Print()
        {
            return $"{companyName},{ModelName},{cost}";
        
        }


    }
}
