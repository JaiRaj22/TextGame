namespace oopadv;

public class Player : Character, IInventory
{
    private readonly IInventory _inventory;
    //passes name back to character name in character class.
    public Player(string name) : base(name)
    {
        _inventory = new Inventory();
    }

    public int Total => _inventory.Total;

    public string[] InventoryList => _inventory.InventoryList;

    public void Add(Item item)
    {
        _inventory.Add(item);
    }

    public bool Contains(string itemname)
    {
        return _inventory.Contains(itemname);
    }

    public Item? Find(string itemname)
    {
        return _inventory.Find(itemname);
    }

    public Item? Find(string itemname, bool remove)
    {
        return _inventory.Find(itemname, remove);
    }

    public void Remove(Item item)
    {
        _inventory.Remove(item);
    }

    public Item? Take(string itemname)
    {
        return _inventory.Take(itemname);
    }

    public void Use(string itemname, string source)
    {
        _inventory.Use(itemname, source);
    }
}