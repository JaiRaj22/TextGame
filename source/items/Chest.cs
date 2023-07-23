namespace oopadv;

public class Chest :Item , IInventory
{
    private readonly House _house;
    private readonly Inventory _inventory = new();
    public override string Name => Text.Language.Chest;

    public bool Locked => true;

    public Chest(Item?[] item, House house)
    {
        CanTake = false;
        _house = house;
        foreach(var item in items)
        {
            Add(item);
        }
    }

    public override void Use(string source)
    {
        if(source == Text.Language.key)
        {
            var items = InventoryList;
            if(Locked)
            {
                Console.WriteLine(Text.Language.Unlockchest);
            }
            if (items.Length == 0)
            {
                Console.WriteLine(Text.Language.Chestempty);
            }
            else
            {
                Console.WriteLine(string.Format(Text.Language.Chestfound, Text.Language.JoinedWordlist(items,Text.Language.And)));
                foreach(var itemname in items)
                {
                    var item = Take(itemname);
                    _house.Player.Add(item);
                }
            }
        }
    }

    public int Total => ((IInventory)_inventory).Total;

    public string[] InventoryList => ((IInventory)_inventory).InventoryList;

    public void Add(Item item)
    {
        ((IInventory)_inventory).Add(item);
    }

    public bool Contains(string itemname)
    {
        return ((IInventory)_inventory).Contains(itemname);
    }

    public Item? Find(string itemname)
    {
        return ((IInventory)_inventory).Find(itemname);
    }

    public Item? Find(string itemname, bool remove)
    {
        return ((IInventory)_inventory).Find(itemname, remove);
    }

    public void Remove(Item item)
    {
        ((IInventory)_inventory).Remove(item);
    }

    public Item? Take(string itemname)
    {
        return ((IInventory)_inventory).Take(itemname);
    }

    public void Use(string itemname, string source)
    {
        ((IInventory)_inventory).Use(itemname, source);
    }
}