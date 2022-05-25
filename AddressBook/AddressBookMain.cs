using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<ContactFile> addressBook = new List<ContactFile>();
        Dictionary<string, List<ContactFile>> myDict = new Dictionary<string, List<ContactFile>>();
        ContactFile contact = new ContactFile();
        public AddressBookMain()
        {
            ContactFile contact1 = new ContactFile()
            {
                FirstName = "Harshal",
                LastName = "Patil",
                Address = "At.Post-Warud",
                Email = "harshalapatil2796@gmail.com",
                PhoneNumber = "9158719379",
                City = "Dhule",
                State = "Maharastra",
                ZipCode = "425404"
            };
            ContactFile contact2 = new ContactFile()
            {
                FirstName = "Girish",
                LastName = "Patil",
                Address = "At.Post-Warud",
                Email = "girishpati2611@gmail.com",
                PhoneNumber = "7057375230",
                City = "Dhule",
                State = "Maharastra",
                ZipCode = "425404"
            };
            addressBook.Add(contact1);
            addressBook.Add(contact2);
        }
        public void CreateContact()
        {
            Console.WriteLine("Enter Your First: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your Email Id: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Your State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code: ");
            contact.ZipCode = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void addcontact (ContactFile contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (ContactFile contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.Email + "\n" + contact.PhoneNumber + "\n" + contact.City + "\n" + contact
                    .State + "\n" + contact.ZipCode);
                Console.WriteLine("\n");
            }
        }
        public void EditContact(string name)
        {
           
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Edit a Contact\n1.FirstName\n2.LastName\n3.Address\n4.Email\n5.PhoneNumber\n6.City\n7.State\n8.ZipCode\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string firstName = Console.ReadLine();
                            contact.FirstName = firstName;
                            break;
                        case 2:
                            string lastName = Console.ReadLine();
                            contact.LastName = lastName;
                            break;
                        case 3:
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        case 5:
                            string phoneNumber = Console.ReadLine();
                            contact.PhoneNumber = phoneNumber;
                            break;
                        case 6:
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 7:
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 8:
                            string zipCode = Console.ReadLine();
                            contact.ZipCode = zipCode;
                            break;
                        default:
                            Console.WriteLine("Enter Correct option");
                            break;
                    }
                }

            }
            Console.WriteLine("\nEdit Successfully\n");
            Display();
        }
        public void DeleteContact(string name)
        {
            ContactFile delete = new ContactFile();
            foreach (var contact in addressBook)
            {

                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Given Name Contact Exists");
                    delete = contact;

                    addressBook.Remove(delete);
                    Console.WriteLine("\nContact Deleted SuccessFully\n");
                }
                else
                {
                    Console.WriteLine("Given Contact Does Not Exists");
                }
            }
            Display();
        }
        public void Adduniquecontacts()
        {
            Console.WriteLine("Enter the Firstname in your contactlist");
            string name = Console.ReadLine();
            foreach (var data in addressBook)
            {
                if (addressBook.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("This contact exists please enter an unique name to store this data");
                        string uniquename = Console.ReadLine();
                        if (myDict.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        myDict.Add(uniquename, addressBook);
                        return;
                    }
                }
            }
            Display();
        }
        public void AddDictionary(string name)
        {
            if (myDict == null)
            {
                myDict.Add(name, addressBook);
            }
            if (NameExists(name) == false)
            {
                myDict.Add(name, addressBook);
            }
            Console.WriteLine(myDict);
        }
        public void DisplayDictionary(string name)
        {
            foreach(var data in myDict)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                }
                //Console.WriteLine(myDict);
            }
            Display();
        }
        public void EditDictionary(string name,string contactName)
        {
            foreach(var data in myDict)
            {
                if(data.Key.Equals(name))
                {
                    addressBook = data.Value;
                }
            }
            EditContact(contactName);
            Display();
        }
        public void DeletDictionary(string name)
        {
            foreach(var data in myDict)
            {
                if(data.Key.Equals(name))
                {
                    addressBook=data.Value;
                }
            }
            DeleteContact(name);
            myDict.Remove(name);
        }
        public bool NameExists(string name)
        {
            foreach (var data in myDict.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
