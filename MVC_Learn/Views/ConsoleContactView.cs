using MVC_Learn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn.Views
{
    public class ConsoleContactView : IContactView
    {
        public void ShowMenu()
        {
            Console.WriteLine("\n=== Contact Manager ===");
            Console.WriteLine("1. List all contacts");
            Console.WriteLine("2. View contact details");
            Console.WriteLine("3. Add new contact");
            Console.WriteLine("4. Update contact");
            Console.WriteLine("5. Delete contact");
            Console.WriteLine("0. Exit");
        }

        public int GetMenuChoice()
        {
            Console.Write("Choose an option: ");
            var input = Console.ReadLine();
            return int.TryParse(input, out int choice) ? choice : -1;
        }

        public Contact GetNewContactInfo()
        {
            Console.WriteLine("\nEnter new contact information:");
            Console.Write("Name: "); var name = Console.ReadLine();
            Console.Write("Phone: "); var phone = Console.ReadLine();
            Console.Write("Email: "); var email = Console.ReadLine();
            return new Contact { Name = name, Phone = phone, Email = email };
        }

        public int GetContactId(string action)
        {
            Console.Write($"\nEnter contact ID to {action}: ");
            var input = Console.ReadLine();
            return int.TryParse(input, out int id) ? id : -1;
        }

        public Contact GetUpdatedContactInfo(Contact existing)
        {
            Console.WriteLine("\nUpdate contact information (leave blank to keep current):");
            Console.Write($"Name ({existing.Name}): ");
            var name = Console.ReadLine();
            Console.Write($"Phone ({existing.Phone}): ");
            var phone = Console.ReadLine();
            Console.Write($"Email ({existing.Email}): ");
            var email = Console.ReadLine();

            existing.Name = string.IsNullOrWhiteSpace(name) ? existing.Name : name;
            existing.Phone = string.IsNullOrWhiteSpace(phone) ? existing.Phone : phone;
            existing.Email = string.IsNullOrWhiteSpace(email) ? existing.Email : email;
            return existing;
        }

        public void DisplayAllContacts(IEnumerable<Contact> contacts)
        {
            Console.WriteLine("\n--- All Contacts ---");
            foreach (var c in contacts)
                Console.WriteLine($"ID: {c.Id}, Name: {c.Name}");
        }

        public void DisplayContact(Contact contact)
        {
            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }
            Console.WriteLine($"\n--- Contact Details (ID: {contact.Id}) ---");
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Email: {contact.Email}");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
