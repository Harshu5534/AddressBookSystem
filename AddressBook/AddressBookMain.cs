using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook=new List<Contact>();
        public void AddContacts()
        {
            Contact contact1 = new Contact()
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
            Contact contact2 = new Contact()
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
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach(var contact in addressBook)            
            {
                Console.WriteLine(contact.FirstName+"\n"+ contact.LastName+"\n"+ contact.Address+"\n"+ contact.Email+"\n"+contact.PhoneNumber+"\n"+ contact.City+"\n"+contact
                    .State+"\n"+contact.ZipCode);
                Console.WriteLine("\n");
            }
        }

    }
}

