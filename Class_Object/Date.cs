using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Date
    {

        private int day, year;
        private String month;


        public void Accept(int dd,String mm,int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        
        }
        public String PrintDate()
        {
            return $"Date :{day}/{month}/{year}";
        
        
        
        }








    }
}
