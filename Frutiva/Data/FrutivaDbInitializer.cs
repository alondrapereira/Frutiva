// using System.Data.Entity;
// using Frutiva.Models;
//
// namespace Frutiva.Data
// {
//     public class FrutivaDbInitializer : CreateDatabaseIfNotExists<FrutivaDbContext>
//     {
//         protected override void Seed(FrutivaDbContext context)
//         {
//             var bases= new List<Base>
//             {
//             new Base{Fruit="Açaí", Price=2.00},
//             new Base{Fruit="Coconut", Price=2.00},
//             new Base{Fruit="Passion Fruit", Price=2.00},
//             new Base{Fruit="Dragon Fruit", Price=3.00},
//             new Base{Fruit="Strawberry-nutella", Price=3.00},
//             };
//             bases.ForEach(b => context.Bases.Add(b));
//             context.SaveChanges();
//             
//             var ingredients= new List<Ingredient>
//             {
//                 new Ingredient{Name="Banana",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Strawberry",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Raspberry",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Blueberry",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Blackberry",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Kiwi",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Coconut",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Mango",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Pineapple",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Grapes",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Papaya",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Watermelon",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Muskmelon",Type=IngredientType.Fruit, Price=1.00},
//                 new Ingredient{Name="Pomegranate",Type=IngredientType.Fruit, Price=1.50},
//                 new Ingredient{Name="Dragon Fruit",Type=IngredientType.Fruit, Price=1.50},
//                 new Ingredient{Name="Granola",Type=IngredientType.Topping, Price=0.50},
//                 new Ingredient{Name="Honey",Type=IngredientType.Topping, Price=0.50},
//                 new Ingredient{Name="Coconut Oil",Type=IngredientType.Topping, Price=1.00},
//                 new Ingredient{Name="Grated Coconut",Type=IngredientType.Topping, Price=0.00},
//                 new Ingredient{Name="Almonds",Type=IngredientType.Topping, Price=0.50},
//                 new Ingredient{Name="Walnuts",Type=IngredientType.Topping, Price=0.50},
//                 new Ingredient{Name="Peanuts",Type=IngredientType.Topping, Price=0.50},
//                 new Ingredient{Name="Peanut Butter",Type=IngredientType.Topping, Price=1.00},
//                 new Ingredient{Name="Almond Butter",Type=IngredientType.Topping, Price=1.00},
//                 new Ingredient{Name="Nutella Butter",Type=IngredientType.Topping, Price=1.00},
//             };
//             ingredients.ForEach(i => context.Ingredients.Add(i));
//             context.SaveChanges();
//         }
//     }
// }