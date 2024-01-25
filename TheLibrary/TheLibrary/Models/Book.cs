namespace TheLibrary.Models;

public class Book : Entry
{
    public Book(string name, Author author, CheckoutStatus checkoutStatus, string description="") : base(name, checkoutStatus, description)
    {
        Author = author;
    }

    /// The primary author of the book.
    public Author Author;
    
}