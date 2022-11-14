using AutoMapper;
using Common.Model;
using Common.Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, UserRessource>()
                .ForMember(userRessource => userRessource .Id, option => option.MapFrom(user => user.Id))
                // .ForMember(userRessource => userRessource .Id, option => option.Ignore()) permet d'ignorer un attribut à mapper
                // .ForAllMembers(userRessource => userRessource.Ignore()) permet d'ignorer tous les attributs
                // .AfterMap((userFromDataBase, userRessourceFromFront) => {
                //   var removedRoles = userFromDataBase.Roles.Where(userRole => userRessourceFromFront.Roles.Contains(userRole)
                //   foreach(var item in removedRoles)
                //   {
                //      userFromDataBase.Roles.Remove(item);
                //   }
                //   var addedRoles = userRessourceFromFront.Roles.Where(roleId => userFromDataBase.Role.All(user => user.RoleId != roleId)
                //   .Select(id => new UserRole { RoleId = id, userId = userRessourceFromFront.Id }
                // })
                ;
        }
    }
}
