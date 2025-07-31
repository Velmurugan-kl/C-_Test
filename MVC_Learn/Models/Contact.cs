using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn.Model
{
    public class Contact
    {
        public int Id { get; set; }          // Unique identifier
        public string Name { get; set; }     // Contact name
        public string Phone { get; set; }    // Phone number
        public string Email { get; set; }    // Email address
    }
}
