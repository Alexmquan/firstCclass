
namespace firstCclass.Repositories;

public class FakeDB
{
  public List<Chore> Chores;

  public FakeDB()
  {
    Chores = new List<Chore>();
    Chores.Add(new Chore(1, "Vacuum Floor", "living room", 2, false));
    Chores.Add(new Chore(2, "Mow Lawn", "Front Yard", 1, true));
    Chores.Add(new Chore(3, "Put away dishes", "kitchen", 3, false));
    Chores.Add(new Chore(4, "make bed", "bedroom", 7, false));
  }

}