using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColinContact_AzureFunctions
{
    public class Database : DbContext
    {
        public static string Server = "colinexioite.database.windows.net";
        public static string UserName = "colin";
        public static string Password = "99uf5VSp0oxL";
        public static string DatabaseName = "ColinContact";

        public static string ConnectionString = $@"Server=tcp:{Server},1433;Initial Catalog={DatabaseName};Persist Security Info=False;User ID={UserName};Password={Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private readonly string _connectionString;

        public Database() : base()
        {
            _connectionString = ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }

    [Table("users")]
    public class Users
    {
        [Key]
        public int ID { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    [Table("loginusers")]
    public class LoginUsers
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }

    [Table("contacts")]
    public class Contacts
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}