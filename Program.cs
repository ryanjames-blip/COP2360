// Ryan DenBleyker
// 2/16/2025
// COP 2360

public class Animal
{
    public string Name;
    public bool LikesHumans;
}
public class Bunny : Animal
{
  public bool LikesCarrots;

  public Bunny (string name, bool likesCarrots = false, bool likesHumans = false) {
    Name = name;
    LikesCarrots = likesCarrots;
    LikesHumans = likesHumans; 
  }

  public void Run() {
    Console.WriteLine("See {0} run!", Name);
  }
}

public class Program() {
    static void Main(string[] args) {
        Bunny buns = new Bunny("buns", true, false);
        buns.Run();
    }
}