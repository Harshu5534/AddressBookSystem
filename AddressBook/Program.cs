using System;
using AddressBook;

namespace LogicalProblems
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------WelCome To Address Book Program------");
            bool end = true;
            Console.WriteLine("SelectNumber\n1.Add Contact\n2.Display\n3.EditContact\n4.DeleteContact\n5.Add Dictionary\n6.Edit Dictionary\n7.Adduniquecontacts\n8.Display Dictionary\n9.Delete Dictionary\n10.End Of Program");
            ContactFile contact = new ContactFile();
            AddressBookMain addContact = new AddressBookMain();
            while (end)
            {
                Console.WriteLine("choose program to exicute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addContact.CreateContact();
                        break;
                    case 2:
                        addContact.Display();
                        break;
                    case 3:
                        string name=Console.ReadLine();
                        addContact.EditContact(name);
                        break;
                    case 4:
                        addContact.DeleteContact("name");
                        break;
                    case 5:
                        Console.WriteLine("Enter the Name for Adding data in Dictionary: ");
                        string dictionaryName=Console.ReadLine();
                        addContact.AddDictionary(dictionaryName);
                        break;
                    case 6:
                        string myDict = Console.ReadLine();
                        string contactName=Console.ReadLine();
                        addContact.EditDictionary(myDict,contactName);
                        break;
                    case 7:
                        addContact.Adduniquecontacts();
                        break;
                    case 8:
                        Console.WriteLine("Enter Name to display data in dictionary: ");
                        string dictionary = Console.ReadLine();
                        addContact.DisplayDictionary(dictionary);
                        break;
                    case 9:
                        addContact.DeletDictionary("FirstName");
                        break;
                    case 10:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;
                }
            }
        }
    }
}