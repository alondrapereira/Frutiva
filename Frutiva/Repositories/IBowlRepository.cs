using Frutiva.Models;

namespace Frutiva.Repositories;

public interface IBowlRepository
{
    public void AddBowl();
    public void DeleteBowlById();
    public void DeleteBowlByName();
    public void EditBowlById();
    public void EditBowlByName();
    public IEnumerable<Bowl> GetBowls();
    public Bowl GetBowlById();
    public Bowl GetBowlByName();
}