namespace EFBootcamp.Data.Models;

public class Item
{
    public int Id { get; set; }
    public int ItemTypeId { get; set; }
    public int ItemStatusId { get; set; }
    
    public int ItemSubTypeId { get; set; }
    public int ParentItemId { get; set; }

    // Navigation Properties
    public ItemStatus? ItemStatus { get; set; }
    public ItemIdentifier? ItemIdentifier { get; set; }
}