using System.Collections.ObjectModel;
using TheLibrary.Models;
using TheLibrary.Services;

namespace TheLibrary.ViewModels;

public class LibraryListViewModel : ViewModelBase
{
    public LibraryListViewModel()
    {
        Entries = Storage.GetLibraryEntries();
    }
    
    public ObservableCollection<ObservableCollection<Entry>> Entries { get; }
    
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    public string HelloWorld => "Hello, world!";
#pragma warning restore CA1822 // Mark members as static

    private EntryStorage Storage { get; set; } = new EntryStorage();
}