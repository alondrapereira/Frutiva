using Frutiva.Models;
using Frutiva.Repositories;
using Frutiva.Services;

namespace Frutiva.Data;

public class MenuService: IMenuService
{
    private readonly IBowlRepository _bowlRepository;
    private readonly FrutivaDbContext _context;

    public MenuService(IBowlRepository bowlRepository, FrutivaDbContext context)
    {
        _bowlRepository = bowlRepository;
        _context = context;
    }

    public Task<Bowl[]> GetBowls()
    {
        var bowls =  _bowlRepository.GetBowls().ToArray();
        return Task.FromResult(bowls);    
    }
    public Task<Base[]> GetBases()
    {
        var bases =  _bowlRepository.GetBases();
        return Task.FromResult(bases.ToArray());    
    }
    public Task<Ingredient[]> GetIngredients()
    {
        var ingredients =  _bowlRepository.GetIngredients();
        return Task.FromResult(ingredients.ToArray());    
    }

}