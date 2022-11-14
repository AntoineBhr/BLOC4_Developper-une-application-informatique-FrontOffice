using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IActions<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T data);
        T Update(T data);
        bool Delete(int id);
    }
}
