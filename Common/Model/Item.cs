using Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Item : Entity
    {
        public Item(int id, string name, int familyId, int supplierId)
        {
            Id = id;
            Name = name;
            FamilyId = familyId;
            SupplierId = supplierId;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FamilyId { get; set; }
        public int SupplierId { get; set; }
        public int Stock { get; set; }
    }
}
