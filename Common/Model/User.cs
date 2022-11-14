using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class User
    {
        public User(int id, string firstName, string email)
        {
            Id = id;
            FirstName = firstName;
            Email = email;
            Roles = new List<UserRole>();

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<UserRole> Roles { get; set; }
    }
}
