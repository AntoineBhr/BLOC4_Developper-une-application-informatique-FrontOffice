using Business;
using Common.Entities;

namespace Services
{
    public class RoleService : IRoleService
    {
        public List<Role> Roles { get; set; }
        public RoleService()
        {
            Roles = new List<Role>
            {
                new Role(1, "Administrateur"),
                new Role(2, "Utilisateur"),
            };
        }
        public List<Role> GetAll()
        {
            return Roles;
        }

        public Role GetById(int id)
        {
            var role = Roles.FirstOrDefault(role => role.Id == id);
            return role;
        }

        public Role GetRoleByName(string roleName)
        {
            var result = Roles.FirstOrDefault(role => role.Name == roleName);
            return result;
        }

        public Role Create(Role role)
        {
            Roles.Add(role);
            return role;
        }

        public bool Delete(int id)
        {
            var result = Roles.FirstOrDefault(role => role.Id == id);
            if (result != null)
            {
                Roles.Remove(result);
                return true;
            }
            return false;
        }

        public Role Update(Role role)
        {
            var existRole = GetById(role.Id);
            if (existRole != null)
            {
                existRole.Name = role.Name;
            }
            return role;
        }
    }
}