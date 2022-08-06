using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1
{
    class Book
    {

        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        public string BookName
        {
            get{return bookName;}
            set { bookName = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set {  bookAuthor= value; }
        }
        public string BookId
        {
            get { return bookId; }
            set {  bookId= value; }
        }
        public string BookType
        {
            get { return bookType; }
            set {  bookType= value; }
        }
        public int BookCopy
        {
            get { return bookCopy; }
            set {  bookCopy= value; }
        }



        public Book() // empty constructor
        {
            bookCounter++;
            Console.WriteLine("Book object created"); 
        }
        public Book(string name, string author, string id , string type , int copy) // parameterized constructor
        {

             BookName=name;
             BookAuthor = author;
             BookId = id;
             BookType = type;
             BookCopy = copy;
             bookCounter++;

       
            Console.WriteLine("Book object created");
        }



        public void showInfo()
        {
            Console.WriteLine("Showing Book Info");
            Console.WriteLine("Name:" +BookName);
            Console.WriteLine("Author:" + BookAuthor);
            Console.WriteLine("Id:" + BookId);
            Console.WriteLine("Type:" + BookType);
            Console.WriteLine("Available Copy:" + BookCopy);
        }

        public void addBookCopy(int x)
        {
            BookCopy = BookCopy + x;
        }


        public static int bookCounter;

        public static void showTotalBookInfo()
        {
            Console.WriteLine("Total books : " + bookCounter);
        }

    }
}
