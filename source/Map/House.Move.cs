namespace oopadv;

public partial class House
{
    public Room Currentroom { get; set; }
    public void Gotoroom(int index)
    {
        if(Currentroom!=null)
        {
            Currentroom.Visited = true;
        }
        Currentroom = Rooms[index];
    }
    public void Gotostartingroom()
    {
        Gotoroom(_random.Next(0, Rooms.Length)); 
    }
}