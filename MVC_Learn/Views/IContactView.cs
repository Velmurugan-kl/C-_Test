using MVC_Learn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn.Views
{
    public interface IContactView
    {
        void ShowMenu();
        int GetMenuChoice();
        Contact GetNewContactInfo();
        int GetContactId(string action);
        Contact GetUpdatedContactInfo(Contact existing);
        void DisplayAllContacts(IEnumerable<Contact> contacts);
        void DisplayContact(Contact contact);
        void DisplayMessage(string message);
    }
}
