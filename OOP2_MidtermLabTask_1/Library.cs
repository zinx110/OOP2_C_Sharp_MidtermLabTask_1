using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1
{
    class Library:Book
    {
        private string libName;
        private string libAddress;

        private Book[] listOfBook= new Book[100];
        private  int totalBook;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        public Book[] ListOfBook    
        {
            get{return listOfBook;}
            set{ listOfBook=value;}
	}

        private int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        
        public Library()
        {
            TotalBook++;
            Console.WriteLine("new library opened");
        }
        
        public Library(string name, string address, Book list)
        {
            LibName=name;
            LibAddress=address;
            listOfBook[totalBook-1]=list;
            
            
            TotalBook++;
            Console.WriteLine("new library opened");
        }
		
		public void ShowLibInfo()
		{
			Console.WriteLine("Library Name: " + LibName);
			Console.WriteLine("Library Address: "+ LibAddress);
			Console.WriteLine("Total Book : "+ totalBook);
			Console.WriteLine("List of all books : ");
			
			for(int i=0; i<ListOfBook.Length;i++)
			{
				if(ListOfBook[i]!=null)
				{
					ListOfBook[i].showInfo();
				}
				else break;
				
			}
			
		
		}
		
		public void AddNewBook(Book book)
		{
			ListOfBook[TotalBook]=book;
		}
		
		public void DeleteBook(Book book)
		{
			int pos=0;
			
			for(int i=0; i<ListOfBook.Length;i++)
			{
				if(ListOfBook[i]==book)
				{
					pos=i;
					TotalBook--;
					break;

				
				}
			}
			for(int i=pos; i<ListOfBook.Length;i++)
			{
				ListOfBook[i]=ListOfBook[i+1];
			}

		}
		
		public void AddNewBookCopy(Book book, int copy)
		{
			for(int i=0; i<ListOfBook.Length;i++)
			{
				if(ListOfBook[i]==book)
				{
					ListOfBook[i].addBookCopy(copy);
					break;
				
				}
			}
			
		}






 


    }
}
