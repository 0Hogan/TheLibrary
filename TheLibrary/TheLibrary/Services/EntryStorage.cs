using System.Collections.ObjectModel;
using TheLibrary.Models;

namespace TheLibrary.Services;

public class EntryStorage
{
    public EntryStorage()
    {
        Settings = new ConfigurationSettings();
    }

    public ObservableCollection<Entry> GetLibraryEntries()
    {
        ObservableCollection<Entry> libraryEntries = new ObservableCollection<Entry>();

        if (Settings.DevelopmentTesting)
        {
            Author tolkien = new Author("Tolkien", "J.", "R.R.");
            libraryEntries.Add(new Book("The Hobbit", tolkien, new CheckoutStatus()));
            libraryEntries.Add(new Book("The Fellowship of the Ring", tolkien, new CheckoutStatus()));
            libraryEntries.Add(new Book("The Two Towers", tolkien, new CheckoutStatus()));
            libraryEntries.Add(new Book("The Return of the King", tolkien, new CheckoutStatus()));
        }
        
        return libraryEntries;
    }
    
    /// A collection of environment settings that may have some bearing on how the entries are stored/retrieved.
    private ConfigurationSettings Settings { get; set; }
}