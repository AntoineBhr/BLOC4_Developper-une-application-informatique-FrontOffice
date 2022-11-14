using Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class SupplierOrder : Entity
    {
        public SupplierOrder(int id, List<Item> items, Supplier supplier)
        {
            Id = id;
            Items = items;
            Supplier = supplier;
        }
        public List<Item> Items { get; set; }
        public Supplier Supplier { get; set; }
    }
}
