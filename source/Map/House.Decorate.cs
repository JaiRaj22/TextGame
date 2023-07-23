namespace oopadv;

public partial class House
{
    public void DecorateRoom()
    {
        foreach(var room in Rooms)
        {
            var roomDescription = Text.Language.Roomdescription[0];
            if(Text.Language.Roomdescription.Count > 1 && _random.Next(0,2)==1)
            {
                roomDescription = Text.Language.Roomdescription[_random.Next(1,Text.Language.Roomdescription.Count)];
                Text.Language.Roomdescription.Remove(roomDescription);
            }
            room.Description = String.Format(Text.Language.DefaultRoomDescription, roomDescription,"{0}");
        }
    }
}