namespace oopadv;

public partial class House
{
    private int Calculateroom (int c ,int r)
    {
        return Math.Clamp(c, -1, Width) + Math.Clamp(r, -1, Height) * Width;
    }
    public void Createroom(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];
        for (var i=0; i<total;i ++)
        {
            var tmproom = new Room();
            var c = i% Width;
            var r = i/Height;
            tmproom.Name = String.Format(Text.Language.DefaultRoomname, i, c, r);

            if(c<Width-1)
            {
                tmproom.Neighbors[Directions.East] = Calculateroom(c + 1, r);
            }
            if(c>0)
            {
                tmproom.Neighbors[(Directions.West)] = Calculateroom(c - 1, r);
            }
            if(r<Height-1)
            {
                tmproom.Neighbors[Directions.South] = Calculateroom(c, r + 1);
            }
            if(r>0)
            {
                tmproom.Neighbors[Directions.North] = Calculateroom(c, r - 1);
            }
            Rooms[i] = tmproom;
        }
    }
}