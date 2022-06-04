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
        Dictionary<string, List<ContactFile>> DictionaryCity = new Dictionary<string, List<ContactFile>>();
        Dictionary<string, List<ContactFile>> DictionaryState = new Dictionary<string, List<ContactFile>>();
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
        public bool DuplicateEntryCheck(string name)
        {
            bool found = addressBook.Any(e => (e.FirstName.ToLower().Equals(name.ToLower())));
            if (found)
            {
                Console.WriteLine("Duplicate Entry Present In AddressBook");
                return true;
            }
            else
            {
                Console.WriteLine("Duplicate Entry Not Present In AddressBook");
                return false;
            }
        }
        public void SearchByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");

            string WantedCityOrState = Console.ReadLine();
            foreach (var data in addressBook)
            {
                string actualcity = data.City;
                string actualState = data.State;
                if (addressBook.Exists(data => (actualcity == WantedCityOrState || actualState == WantedCityOrState)))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("ZipCode : " + data.ZipCode);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("City Or State Doesnt Exists In AddressBook\n");
                return;
            }
        }
        public void CountByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string WantedCityOrState = Console.ReadLine();
            int Count = 0;
            foreach (var data in addressBook)
            {
                string ActualCity = data.City;
                string ActualState = data.State;
                if (addressBook.Exists(data => (ActualCity == WantedCityOrState) || (ActualState == WantedCityOrState)))
                {
                    Count++;
                }
            }
            Console.WriteLine("There are {0} Persons in {1}", Count, WantedCityOrState);
        }
        public void ContactByCityInDictionary()
        {
            // adding list to cities dictionary
            try
            {
                var data = addressBook.GroupBy(x => x.City);
                foreach (var cities in data)
                {
                    List<ContactFile> cityList = new List<ContactFile>();
                    foreach (var city in cities)
                    {
                        cityList.Add(city);
                    }
                    DictionaryCity.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of city dictionary      
        public void DictionayCity_Display()
        {
            if (DictionaryCity.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (DictionaryCity.Count >= 1)
            {
                foreach (KeyValuePair<string, List<ContactFile>> addressBooks in DictionaryCity)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (ContactFile items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.FirstName + " " + items.LastName}, Phone Number: {items.Address}, City: {items.Email}, State: {items.PhoneNumber}" +
                            $"\n Address: {items.City}, Zipcode: {items.State}, Email: {items.ZipCode}");
                        Console.WriteLine();
                    }
                }
            }
        }
        public void ContactByStateInDictionary()
        {
            // adding list to states dictionary
            try
            {
                var data = addressBook.GroupBy(x => x.State);
                foreach (var states in data)
                {
                    List<ContactFile> stateList = new List<ContactFile>();
                    foreach (var state in states)
                    {
                        stateList.Add(state);
                    }
                    DictionaryState.Add(states.Key, stateList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of state dictionary      
        public void DictionayState_Display()
        {
            if (DictionaryState.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (DictionaryState.Count >= 1)
            {
                foreach (KeyValuePair<string, List<ContactFile>> addressBooks in DictionaryState)
                {
                    Console.WriteLine("Contacts From State: " + addressBooks.Key);
                    foreach (ContactFile items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.FirstName + " " + items.LastName}, Phone Number: {items.Address}, City: {items.Email}, State: {items.PhoneNumber}" +
                            $"\n Address: {items.City}, Zipcode: {items.State}, Email: {items.ZipCode}");
                        Console.WriteLine();
                    }
                }
            }
        }
        public void SortingList()
        {
            List<ContactFile> SortedList = new List<ContactFile>();
            SortedList = addressBook.OrderBy(s => s.FirstName).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNumber);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                    
                }
            }
        }
        public void SortingList_city()
        {
            List<ContactFile> SortedList = new List<ContactFile>();
            SortedList = addressBook.OrderBy(s => s.City).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNumber);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                }
            }
        }
        // sorting the contact list by state name in alphabetical order
        public void SortingList_State()
        {
            List<ContactFile> SortedList = new List<ContactFile>();
            SortedList = addressBook.OrderBy(s => s.State).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNumber);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                }
            }
        }
        // sorting the contact list by zip
        public void SortingList_Zip()
        {
            List<ContactFile> SortedList = new List<ContactFile>();
            SortedList = addressBook.OrderBy(s => s.ZipCode).ToList();
            //foreach(var data in People.OrderBy(s => s.firstName).ToList())
            foreach (var data in SortedList)
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine("Phone Number of person : " + data.PhoneNumber);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.ZipCode);
                }
            }
        }
    }
}
