using Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Supplier : Entity
    {
        public Supplier(int id, string name)
        {
            Id = id;
            Name = name;
        }
        string Name { get; set; }
    }
}
