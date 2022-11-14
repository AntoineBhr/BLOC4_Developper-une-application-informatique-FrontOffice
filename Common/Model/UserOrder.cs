using Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class UserOrder : Entity
    {
        public UserOrder(int id, List<Item> items, int userId)
        {
            Id = id;
            Items = items;
            UserId = userId;
        }
        public List<Item> Items { get; set; }
        public int UserId { get; set; }
    }
}
