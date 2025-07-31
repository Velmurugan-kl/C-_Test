using MVC_Learn.Model;
using MVC_Learn.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn.Controllers
{
    public class ContactController
    {
        private readonly IContactView _view;
        private readonly List<Contact> _contacts = new List<Contact>();
        private int _nextId = 1;

        public ContactController(IContactView view)
        {
            _view = view;
        }

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                _view.ShowMenu();
                switch (_view.GetMenuChoice())
                {
                    case 1: List(); break;
                    case 2: ViewDetails(); break;
                    case 3: Add(); break;
                    case 4: Update(); break;
                    case 5: Delete(); break;
                    case 0: exit = true; break;
                    default: _view.DisplayMessage("Invalid choice."); break;
                }
            }
        }

        public void List()
        {
            _view.DisplayAllContacts(_contacts);
        }

        public void ViewDetails()
        {
            int id = _view.GetContactId("view");
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            _view.DisplayContact(contact);
        }

        public void Add()
        {
            var newContact = _view.GetNewContactInfo();
            newContact.Id = _nextId++;
            _contacts.Add(newContact);
            _view.DisplayMessage("Contact added.");
        }

        public void Update()
        {
            int id = _view.GetContactId("update");
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                _view.DisplayMessage("Contact not found.");
                return;
            }
            var updated = _view.GetUpdatedContactInfo(contact);
            // no extra logic needed—View modifies object directly
            _view.DisplayMessage("Contact updated.");
        }

        public void Delete()
        {
            int id = _view.GetContactId("delete");
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                _view.DisplayMessage("Contact not found.");
                return;
            }
            _contacts.Remove(contact);
            _view.DisplayMessage("Contact deleted.");
        }
    }
}
