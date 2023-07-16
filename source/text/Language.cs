namespace oopadv;

public abstract class Language
{
    public string Welcome { get; protected set; } = " ";
    public string Chooseyourname { get; protected set; } = " ";
    public string Defaultname { get; protected set; } = " ";
    public string DefaultRoomname { get; protected set; } = " ";
    public string DefaultRoomDescription { get; protected set; } = " ";
    public string ActionError { get; protected set; } = "";
    public string Go { get; protected set; } = "";
    public string GoError { get; protected set; } = "";
    public string Whattodo { get; protected set; } = "";
    public string Quit { get; protected set; } = "";
    public string Roomnew { get; protected set; } = "";
    public string Roomold { get; protected set; } = "";
    public string And { get; protected set; } = "";
}