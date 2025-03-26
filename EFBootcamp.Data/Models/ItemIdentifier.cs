namespace EFBootcamp.Data.Models;

public class ItemIdentifier
{
    public int IdentifierId { get; set; }
    public int ItemId { get; set; }
    
    public List<Item> Items { get; set; }
}