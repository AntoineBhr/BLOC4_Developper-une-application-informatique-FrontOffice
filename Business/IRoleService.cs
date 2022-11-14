using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IRoleService : IActions<Role>
    {
        Role GetRoleByName(string roleName);

    }
}
