using Frutiva.Data;
using Frutiva.Models;

namespace Frutiva.Repositories;

public class BowlRepository: IBowlRepository
{
    private readonly FrutivaDbContext _context;

    public BowlRepository(FrutivaDbContext ctx)
    {
        _context = ctx;
    }
    public void AddBowl(Bowl bowl)
    {
        _context.Add(bowl);
        _context.SaveChanges();
    }

    public void DeleteBowlById(int id)
    {
        var bowl = _context.Bowls.First(b => b.BowlId == id);
        _context.Remove(bowl);
        _context.SaveChanges();    
    }

    public void DeleteBowlByName(string name)
    {
        var bowl = _context.Bowls.First(b => b.Name == name);
        _context.Remove(bowl);
        _context.SaveChanges();
    }
    
    public IEnumerable<Bowl> GetBowls()
    {
        return _context.Bowls;
    }

    public Bowl GetBowlById(int id)
    {
        return _context.Bowls.First(b => b.BowlId == id);
    }

    public Bowl GetBowlByName(string name)
    {
        return _context.Bowls.First(b => b.Name == name);
    }
    public IEnumerable<Base> GetBases()
    {
        return _context.Bases;
    }

    public Base GetBaseById(int id)
    {
        return _context.Bases.First(b => b.BaseId == id);
    }

    public Base GetBaseByFruit(string fruit)
    {
        return _context.Bases.First(b => b.Fruit == fruit);
    }
    public IEnumerable<Ingredient> GetIngredients()
    {
        return _context.Ingredients;
    }

    public Ingredient GetIngredientById(int id)
    {
        return _context.Ingredients.First(i => i.IngredientId == id);
    }

    public Ingredient GetIngredientByName(string name)
    {
        return _context.Ingredients.First(i => i.Name == name);
    }
}