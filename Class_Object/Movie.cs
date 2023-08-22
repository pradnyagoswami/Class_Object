using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Movie
    {
        private int mid;
        private string m_name;
        private int price;
        private int noofTickets = 20;
        private int totalNo;
        private string type;
        private int totalcost = 0, num;


        /** public Movie()
         {
             int mid = 0;
             String m_name = "";
             double price = 0;
             int noofTickets = 0;
             int totalNo = 0;
            **/



        public Movie(int mid, string m_name)
        {
            this.mid = mid;
            this.m_name = m_name;

        }
        public string Disply()
        {

            return $"{mid},{m_name},{price},{noofTickets}";

        }

        public void FindAvailableTicket()
        {
            Console.WriteLine("Enter Number of Tickets to Book");
            num = Convert.ToInt32(Console.ReadLine());

            if (noofTickets > num)
            {
                noofTickets = noofTickets - num;
                this.CalculateTickets();

            }
            else
            {
                Console.WriteLine("Insufficeient tickets");

            }

        }
        public void CalculateTickets()
        {
            Console.WriteLine("1 silver =100k 2 Gold =200 3 Paltinum =300");
            Console.WriteLine("Enter Type");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {

                case 1:
                    type = "silver";
                    price = 100;
                    break;


                case 2:
                    type = "Gold";
                    price = 200;
                    break;

                case 3:
                    type = "Platinum";
                    price = 300;
                    break;

                default:
                    Console.WriteLine($"invalid choice");
                    break;

            }
            totalcost = num * price;


        }
        public void Details()
        {
            Console.WriteLine($" Movie name = {m_name} Movie Type = {type} Number of Tickets = {noofTickets} Total cos = {totalcost}");

        }



    }


    }

