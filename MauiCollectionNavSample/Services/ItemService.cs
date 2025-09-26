using MauiCollectionNavSample.Models;

namespace MauiCollectionNavSample.Services;

public class ItemService
{
    public List<Item> GetItems()
    {
        return Enumerable.Range(1, 40)
            .Select(i => new Item
            {
                Id = i,
                Title = $"Item {i}",
                Description = $"This is the description for Item {i}."
            })
            .ToList();
    }

    public Item? GetItemById(int id)
    {
        return GetItems().FirstOrDefault(x => x.Id == id);
    }
}