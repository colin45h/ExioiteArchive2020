using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColinContactManagerUniversal
{
    class User
    {
        public int ID { get; set; }
        // Fields
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

    }
}
