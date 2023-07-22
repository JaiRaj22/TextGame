using System.Text;

namespace oopadv;

public class Room :IInventory
{
    public string Name { get; set; } = Text.Language.DefaultRoomname;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;
    private readonly IInventory inventory = new Inventory();
    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
         {Directions.North,-1},
         {Directions.South,-1},
         {Directions.East,-1},
         {Directions.West,-1},
        {Directions.None,-1 },
    };
    public bool Visited { get; set; }

    public int Total => inventory.Total;

    public string[] InventoryList => inventory.InventoryList;

    public override string ToString()
    {
        var sb = new StringBuilder();
        if(Visited)
        {
            sb.Append(string.Format(Text.Language.Roomold, Name));
        }
        else
        {
            sb.Append(string.Format(Text.Language.Roomnew, Name));
        }
        var names = Enum.GetNames(typeof(Directions));
        var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();
        var description = string.Format(Description, Text.Language.JoinedWordlist(directions, Text.Language.And));
        sb.Append(description);
        return sb.ToString();
    }

    public void Add(Item item)
    {
        inventory.Add(item);
    }

    public bool Contains(string itemname)
    {
        return inventory.Contains(itemname);
    }

    public Item? Find(string itemname)
    {
        return inventory.Find(itemname);
    }

    public Item? Find(string itemname, bool remove)
    {
        return inventory.Find(itemname, remove);
    }

    public void Remove(Item item)
    {
        inventory.Remove(item);
    }

    public Item? Take(string itemname)
    {
        return inventory.Take(itemname);
    }

    public void Use(string itemname, string source)
    {
        inventory.Use(itemname, source);
    }
}