using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNet.Models
{
    public class Menu
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
