using oopadv;
using System.Reflection.Metadata.Ecma335;

public class Inventory : IInventory
{
    private List<Item> Items { get; } = new();

    public int Total => Items.Count;

    public string[] InventoryList => Items.Select(i => i.Name).ToArray();

    public void Add(Item item)
    {

        Items.Add(item);
    }
    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public Item? Find(string itemname)
    {
        foreach (var item in Items)
        {
            if (item?.Name == itemname)
                return item;
        }
        return null;
    }

    public Item? Find(string itemname, bool remove)
    {
        var item = Find(itemname);
        if (item != null && remove)
        {
            Remove(item);
        }
        return item;
    }
    public bool Contains(string itemname)
    {
        return Find(itemname) != null;
    }

    public Item? Take(string itemname)
    {
        return Find(itemname, true);
    }

    public void Use(string itemname, string source)
    {
        var item = Find(itemname);
        if (item != null)
        {
            item.Use(source);
            if (item.SingleUse)
            {
                Remove(item);
            }
            return;
        }
        Console.WriteLine(Text.Language.Noitem, itemname);
    }
}