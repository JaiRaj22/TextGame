namespace oopadv;

public abstract partial class Language
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
    public string Comma { get; protected set; } = "";
    public string Space { get; protected set; } = "";
    public List<string> Roomdescription { get; protected set; }
    public string Noitem { get; protected set; } = "";
    public string Backpack { get; protected set; } = "";
    public string BackpackError { get; protected set; } = "";
    public string BackpackDesc { get; protected set; } = "";
    public string Chest { get; protected set; } = "";
    public string Unlockchest { get; protected set; } = "";
    public string key { get; protected set; } = "";
    public string Chestempty { get; protected set; } = "";
    public string Chestfound { get; protected set; } = "";
}