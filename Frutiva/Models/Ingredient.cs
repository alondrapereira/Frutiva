using System.Collections.Generic;

namespace Frutiva.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public IngredientType Type { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Bowl> Bowls { get; set; }
    }
    public enum IngredientType
    {
        Fruit, Topping
    }
}