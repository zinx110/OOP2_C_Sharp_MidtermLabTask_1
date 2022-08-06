using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1
{
class AddressBook
{

	private string ownerName;
	private string info;
	private Contact[] listOfContact=new Contact[100];
	public string OwnerName
	{
	
		get{return ownerName;}
		set{ownerName=value;}
	}
	public string Info
	{
	
		get{return info;}
		set{info = value;}
	}
	
	
	
	public Contact[] ListOfContact    
    {
       get{return listOfContact;}
       set{ listOfContact=value;}
	}
	
	
	public AddressBook()
	{
	
		Console.WriteLine("AddressBook Created");
	}
	
	public AddressBook(string name, string info)
	{
		OwnerName=name;
		Info=info;
		
	
		Console.WriteLine("AddressBook Created");
	}
	
	public void ShowAllContactInfo()
	{
		Console.WriteLine("Onwer Name: " + OwnerName);
			Console.WriteLine("Address : "+ Info);
			
			Console.WriteLine("List of all Contacts : ");
			
			for(int i=0; i<ListOfContact.GetLength(1);i++)
			{
				if(ListOfContact[i]!=null)
				{
					ListOfContact[i].ShowPersonInfo();	
				}
				else break;
				
			}
	
		
	}
	
	
	
	public void AddContact(Contact con)
	{
		int pos=100;
		for(int i=0;i<ListOfContact.Length;i++)
		{
			if(ListOfContact[i]==null)
			{
			
				pos=i;
				break;
			}
				
		}
		ListOfContact[pos]=con;
	}
	
	
	
	
	
		public void DeleteContact(Contact con)
		{
			int pos=100;
			
			for(int i=0; i<ListOfContact.Length;i++)
			{
				if(ListOfContact[i]==con)
				{
					pos=i;
					
					break;

				
				}
			}
			for(int i=pos; i<ListOfContact.Length;i++)
			{
				ListOfContact[i]=ListOfContact[i+1];
			}

		}
	
	
	
}
}
