namespace oopadv;

public partial class House
{
    public Player Player { get;  }
    private readonly Random _random = new(1234);
    public House(Player player)
    {
        Player = player;
    }
}