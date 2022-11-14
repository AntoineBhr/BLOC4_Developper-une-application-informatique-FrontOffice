using Business;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        public List<User> Users { get; set; }

        public UserService()
        {
            Users = new List<User>
            {
                new User(1, "Farhatdu33", "farhat@gmail.com"),
                new User(2, "JoséleBoss", "josetheboss@wanadoo.fr"),
                new User(3, "Miguelito", "miguelito@gmail.com"),
                new User(4, "Bernardo974", "beber@outlook.fr")
            };
        }
        public List<User> GetAll()
        {
            return Users;
        }

        public bool IfEmailExist(string email)
        {
            var result = Users.Where(user => user.Email == email);
            return result.Any();
        }

        public User GetById(int id)
        {
            return Users.FirstOrDefault(user => user.Id == id);
        }

        public User GetByEmail(string email)
        {
            return Users.FirstOrDefault(user => user.Email == email);
        }

        public bool Delete(int id)
        {
            var result = Users.FirstOrDefault(user => user.Id == id);
            if (result != null)
            {
                Users.Remove(result);
                return true;
            }
            return false;
        }

        public User Create(User user)
        {
            Users.Add(user);
            return user;
        }

        public User Update(User user)
        {
            var updatedUser = GetById(user.Id);
            if (updatedUser != null)
            {
                updatedUser.Email = user.Email;
                updatedUser.FirstName = user.FirstName;
                updatedUser.LastName = user.LastName;
            }
            return user;
        }
    }
}
