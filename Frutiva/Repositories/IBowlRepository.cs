using Frutiva.Models;
using Microsoft.AspNetCore.Components;

namespace Frutiva.Repositories;

public interface IBowlRepository
{
    public void AddBowl(Bowl bowl);
    public void DeleteBowlById(int id);
    public void DeleteBowlByName(string name);
    public IEnumerable<Bowl> GetBowls();
    public Bowl GetBowlById(int id);
    public Bowl GetBowlByName(string name);
    public IEnumerable<Base> GetBases();
    public Base GetBaseById(int id);
    public Base GetBaseByFruit(string fruit);
    public IEnumerable<Ingredient> GetIngredients();
    public Ingredient GetIngredientById(int id);
    public Ingredient GetIngredientByName(string name);
}