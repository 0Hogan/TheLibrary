using System.Collections.ObjectModel;
using TheLibrary.Models;

namespace TheLibrary.Services;

public class EntryStorage
{
    public EntryStorage()
    {
        Settings = new ConfigurationSettings();
    }

    public ObservableCollection<ObservableCollection<Entry>> GetLibraryEntries()
    {
        var libraryEntries = new ObservableCollection<ObservableCollection<Entry>>();

        if (Settings.DevelopmentTesting)
        {
            var books = new ObservableCollection<Book>();
            var tolkien = new Author("Tolkien", "J.", "R.R.");
            books.Add(new Book("The Hobbit", tolkien, new CheckoutStatus()));
            books.Add(new Book("The Fellowship of the Ring", tolkien, new CheckoutStatus()));
            books.Add(new Book("The Two Towers", tolkien, new CheckoutStatus()));
            books.Add(new Book("The Return of the King", tolkien, new CheckoutStatus()));
            libraryEntries.Add(books);
        }
        
        return libraryEntries;
    }
    
    /// A collection of environment settings that may have some bearing on how the entries are stored/retrieved.
    private ConfigurationSettings Settings { get; set; }
}