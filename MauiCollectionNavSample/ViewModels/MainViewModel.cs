using MauiCollectionNavSample.Models;
using MauiCollectionNavSample.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiCollectionNavSample.ViewModels;

public class MainViewModel : BindableObject
{
    private readonly ItemService _itemService;

    public ObservableCollection<Item> Items { get; }
    //public ICommand ItemTappedCommand { get; }

    public ICommand CollectionTappedCommand { get; }


    private Item? _selectedItem;
    public Item? SelectedItem
    {
        get => _selectedItem;
        set
        {
            if (_selectedItem != value)
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
                // Optionally, execute a command here when the selection changes
                // SelectedItemChangedCommand.Execute(value); 
            }
        }
    }

    //private Item? _previousSelectedItem;
    //public Item? PreviousSelectedItem
    //{
    //    get => _previousSelectedItem;
    //    set
    //    {
    //        if (_previousSelectedItem != value)
    //        {
    //            _previousSelectedItem = value;
    //            OnPropertyChanged(nameof(PreviousSelectedItem));
    //            // Optionally, execute a command here when the selection changes
    //            // SelectedItemChangedCommand.Execute(value); 
    //        }
    //    }
    //}


    public MainViewModel()
    {
        _itemService = new ItemService();
        Items = new ObservableCollection<Item>(_itemService.GetItems());

        //ItemTappedCommand = new Command<Item>(OnItemTapped);

        CollectionTappedCommand = new Command<Item>(OnCollectionTapped);

    }

    //private async void OnItemTapped(Item tappedItem)
    //{
    //    if (tappedItem == null) return;

    //    PreviousSelectedItem = SelectedItem;
    //    SelectedItem = null;

    //    // Navigate with query parameter
    //    //await Shell.Current.GoToAsync($"///DetailPage?Id={tappedItem.Id}");
    //    await Shell.Current.GoToAsync($"DetailPage?Id={tappedItem.Id}");


    //}

    private async void OnCollectionTapped(Item selectedItem)
    {
        if (selectedItem == null) 
            return;

        await Shell.Current.GoToAsync($"DetailPage?Id={selectedItem.Id}");

        // Handle tap on the CollectionView, selectedItem is the current selection
        // Add your logic here
    }
}