using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShushaPharmacy.Models
{
    public class User:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int UserRole { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }

        public User(int id ,string name, string surname, int userRole, string userName)
        {
            Name = name;
            Surname = surname;
            UserRole = userRole;
            UserName = userName;
            Created = DateTime.Now;
            Updated = DateTime.Now;
            Id = id;
        }




    }
}
