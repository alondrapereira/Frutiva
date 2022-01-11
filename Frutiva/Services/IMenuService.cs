using Frutiva.Models;

namespace Frutiva.Services;

public interface IMenuService
{
    public Task<Bowl[]> GetBowls();
    public Task<Base[]> GetBases();

    public Task<Ingredient[]> GetIngredients();
}