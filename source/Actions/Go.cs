namespace oopadv;

public class Go : Action
{
    public override string Name => Text.Language.Go;
    private readonly House _house;
    public Go(House house)
    {
        _house = house;
    }
    public override void Execute(string[] args)
    {
        var currentroom = _house.Currentroom;
        var dir = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();
        Enum.TryParse(dir, out Directions newDirections);
        var nextRoomindex = currentroom.Neighbors[newDirections];
        if (nextRoomindex == -1 || newDirections == Directions.None)
            Console.WriteLine(Text.Language.GoError);
        else
            _house.Gotoroom(nextRoomindex);
    }
}