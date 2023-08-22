using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Bank
    {
        private int accno;
        private String accname;
        private double accbal;


        public Bank(int accno,String accname,double accbal)
        {

            this.accno = accno;
            this.accname = accname;
            this.accbal = accbal;
        }
        public void Credit(double creditamount)
        {
            
            accbal +=creditamount;  

            
        }
        public String Debit(double debitamt)
        {
            String msg = "";
            if (accbal <= debitamt)
            {
                accbal = accbal - debitamt;
                msg = "Done transaction";
            }
            else 
            {

                msg = "Insufficient balance";
            
            }
            return msg;
        
        }

        public String print()
        { 
        
         return $"Account no = {accno}\n Account holder name = {accname}\n Account balance {accbal}";
        
        
        
        }


    }
}
