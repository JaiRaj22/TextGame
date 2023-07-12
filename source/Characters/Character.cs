namespace oopadv;
//abstract is used to highlight that this class is not to be instatiated. This class is goin to be base class through which other class is goin to get their logic.
public abstract class Character
{
    public string Name { get; set; }
    public Character(string name)
    {
        Name = name;
    }
}