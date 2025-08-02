using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static threeemonthCsharp.Device;

namespace threeemonthCsharp
{
    public class contactmanager
    {
        List<Contact> contacts = new List<Contact>();
        private int nextid = 1;
        public void contact()
        {
            while (true)
            {
                Console.WriteLine(" ---Contact Manager---\n 1.Add Contact \n 2.View Contacts \n 3.Search Contact \n 4.Update Contact\n 5.Delete Contact \n 6.Exit\n Enter your choice");
                
                if(!int.TryParse(Console.ReadLine(),out int number))
                {
                    Console.WriteLine("Choose right option");
                }
                switch (number)
                {
                    case 1: Addcontact(); break;
                    case 2: Viewcontact(); break;
                    case 3: Searchcontact(); break;
                    case 4: Updatecontact(); break;
                    case 5: Deletecontact(); break;
                    case 6: return; // exit the app
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }

        }
        public void Addcontact()
        {
            Contact contact = new Contact();
            contact.Id= nextid++;
            Console.WriteLine("enter name");
            contact.Name= Console.ReadLine();
            Console.WriteLine("enter Email");
            contact.Email = Console.ReadLine();
            Console.WriteLine("enter phonenumber");
            contact.PhoneNumber = Console.ReadLine();
            contacts.Add(contact);
            Console.WriteLine("Added successfullly");
        }
        public void Viewcontact()
        {
            if (contacts.Count==0)
            {
                Console.WriteLine("no contact available");
            }
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"ID:{contact.Id}\n Name:{contact.Name} \n email:{contact.Email}\n phone number:{contact.PhoneNumber}");
            }
        }
        public void Searchcontact()
        {
            Console.WriteLine("enter name to search:");
            string name = Console.ReadLine();
            var result = contacts.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();
            if (result.Any())
            {
                Console.WriteLine("--Searchcontact result--");
                foreach (Contact contact in result)
                {
                    Console.WriteLine($"ID:{contact.Id}\n Name:{contact.Name} \n email:{contact.Email}\n phone number:{contact.PhoneNumber}");
                }
            }
            else
            {
                Console.WriteLine("Not matched items");
            }
        }
        public void Updatecontact()
        {
            Console.WriteLine("Enter the contact id:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var contact = contacts.FirstOrDefault(c => c.Id==id);
                if (contact!=null)
                {
                    Console.Write("Enter new Name (leave blank to keep unchanged): ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new Phone (leave blank to keep unchanged): ");
                    string newPhone = Console.ReadLine();
                    Console.Write("Enter new Email (leave blank to keep unchanged): ");
                    string newEmail = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName)) contact.Name = newName;
                    if (!string.IsNullOrWhiteSpace(newPhone)) contact.PhoneNumber = newPhone;
                    if (!string.IsNullOrWhiteSpace(newEmail)) contact.Email = newEmail;
                    Console.WriteLine("contact updated");
                }
                else
                {
                    Console.WriteLine("contact is not avaialable");
                }
            }
            else
            {
                Console.WriteLine("Invalid id");
            }

        }
        public void Deletecontact()
        {
            Console.WriteLine("Enter the contact id:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var contact = contacts.FirstOrDefault(c => c.Id==id);
                 if (contact!=null)
                {
                    contacts.Remove(contact);
                    Console.WriteLine("contact deleted");
                }
                Console.WriteLine("contact not found");
            }
            Console.WriteLine("Invalid records");
        }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

}
