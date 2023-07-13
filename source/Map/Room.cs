namespace oopadv;

public class Room
{
    public string Name { get; set; } = Text.Language.DefaultRoomname;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;
    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
         {Directions.North,-1},
         {Directions.South,-1},
         {Directions.East,-1},
         {Directions.West,-1},
    };
    public bool Visited { get; set; }
   

}