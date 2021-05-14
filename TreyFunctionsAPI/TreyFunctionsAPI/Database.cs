using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreyFunctionsAPI
{
    public class Database : DbContext
    {
        public static string Server = "treyexioite.database.windows.net";
        public static string UserName = "Trey";
        public static string Password = "W5ZN1Sv1rVVQ";
        public static string DatabaseName = "treycontact";

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

        //public virtual DbSet<Users> Users { get; set; }

    }

    [Table("Contacts")]
    public class Contacts
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
