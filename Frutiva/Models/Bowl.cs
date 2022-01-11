using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Frutiva.Models
{
    public class Bowl
    {
        public int BowlId { get; set; }
        public string Name { get; set; }
        public virtual Base Base{ get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public double Price { get; set; }
    }
}

