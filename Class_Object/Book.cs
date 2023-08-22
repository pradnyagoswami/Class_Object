using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Book
    {
        private int bookid;
        private String Bookname;
        private double BookPrice;
        private String BookAuthorNAme;


        public Book()
        {

            int bookid = 0;
            String Bookname = "";
            double BookPrice = 0.0;
            String BookAuthorNAme = "";
        
        
        }
        public Book(int Bookid,String Bookname,double BookPrice,String BookAuthorNAme)
        {
            this.bookid = bookid;
            this.Bookname = Bookname;
            this.BookPrice = BookPrice;
            this.BookAuthorNAme = BookAuthorNAme;
        
        }


        public String Disply()
        {

            return $"Book :Book id = {bookid}\n Book name = {Bookname}\n Book Price = {BookPrice}\n BookAuthor Name = {BookAuthorNAme}";
        
        
        }





    }
}
