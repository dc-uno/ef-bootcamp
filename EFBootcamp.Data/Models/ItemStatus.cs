namespace EFBootcamp.Data.Models;

public class ItemStatus
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<Item> Items { get; set; }
}