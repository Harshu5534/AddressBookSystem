using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FileIOOperations
    {
        public List<ContactFile> People1 = new List<ContactFile>();
        public void WriteToTextFile()
        {
            string ABC = @"C:\Users\santo\OneDrive\Desktop\CSharpCodes\AddressBook\AddressBook\TextFile1.txt";
            using (TextWriter sw = File.CreateText(ABC))
            {
                foreach (ContactFile item in People1)
                {
                    sw.WriteLine("First Name:" + item.FirstName.ToString());
                }
            }
        }
        public void AddPerson1()
        {
            ContactFile contact = new ContactFile();
            int Flag = 0;
            Console.WriteLine("Enter the First name :");
            contact.FirstName = Console.ReadLine();
            string FirstNameToBeAdded = contact.FirstName;
            foreach (var data in People1)
            {
                if (People1.Exists(data => data.FirstName == FirstNameToBeAdded))
                {
                    Flag++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record.");
                    break;
                }
            }
            if (Flag == 0)
            {
                Console.WriteLine("Enter the Last name :");
                contact.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Address :");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter the Email :");
                contact.Email = Console.ReadLine();
                Console.WriteLine("Enter the Phone Number :");
                contact.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the City :");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter the State :");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter the Zip Code :");
                contact.ZipCode = Console.ReadLine();
            }
            People1.Add(contact);
        }

    }

}

