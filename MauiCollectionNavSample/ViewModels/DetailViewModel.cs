using MauiCollectionNavSample.Models;
using MauiCollectionNavSample.Services;

namespace MauiCollectionNavSample.ViewModels;

[QueryProperty(nameof(Id), "Id")]
public class DetailViewModel : BindableObject
{
    private readonly ItemService _itemService;
    private int _id;
    private string _title;
    private string _description;

    public string Title
    {
        get => _title;
        set { _title = value; OnPropertyChanged(); }
    }

    public string Description
    {
        get => _description;
        set { _description = value; OnPropertyChanged(); }
    }

    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            LoadItem(_id);
        }
    }

    public DetailViewModel()
    {
        _itemService = new ItemService();
    }

    private void LoadItem(int id)
    {
        var item = _itemService.GetItemById(id);
        if (item != null)
        {
            Title = item.Title;
            Description = item.Description;
        }
    }
}
