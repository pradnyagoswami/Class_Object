using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Account
    {

        private int Acc_NO;
        private String Acc_type;
        private double Acc_bal;
        private double Total_Bal;
        private double Amount;

        public void Accept(int Acc_No,String Acc_type,double Acc_bal)
        { 
             this.Acc_NO=Acc_No;
            this.Acc_type=Acc_type;
            this.Acc_bal=Acc_bal;
        
        }
        public String Show()
        {
           return $"Account number{Acc_NO}\n Account type{Acc_type}\n Accont balance{Acc_bal}";
        
        }
        public void Withdraw(int Amount)
        {
            if (Acc_bal > Amount)
            {
                Acc_bal = Acc_bal - Amount;
                Console.WriteLine(Amount);

            }
        
        }



    }
}
