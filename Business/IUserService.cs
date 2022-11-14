using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IUserService : IActions<User>
    {
        User GetByEmail(string email);
    }
}
