﻿using System;
using AddressBook;

namespace LogicalProblems
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------WelCome To Address Book Program------");
            bool end = true;
            Console.WriteLine("SelectNumber\n1.Add Contact\n2.Display\n3.EditContact\n4.DeleteContact\n5.Add Dictionary\n6.Edit Dictionary\n7.Adduniquecontacts\n8.Delete Dictionary\n9.DuplicateEntryCheck\n10.SearchByCityState\n11.End Of Program");
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
                        addContact.DeletDictionary("FirstName");
                        break;
                    case 9:
                        string name2 = Console.ReadLine();
                        bool existName = addContact.DuplicateEntryCheck(name2);
                        if (existName)
                        {
                            Console.WriteLine("This contact already exists please add new entry");
                        }
                        break;
                    case 10:
                        addContact.SearchByCityState();
                        break;
                    case 11:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;
                }
            }
        }
    }
}