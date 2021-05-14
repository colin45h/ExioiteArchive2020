using System.ComponentModel;

namespace ColinContactManager
{
    public class User
    {
        public int ID { get; set;}
        // Fields
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}