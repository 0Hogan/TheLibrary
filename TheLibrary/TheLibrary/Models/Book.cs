namespace TheLibrary.Models;

public class Book : Entry
{
    public Book(string name, Author author, CheckoutStatus checkoutStatus, string description="") : base(name, checkoutStatus, description)
    {
        Author = author;
    }

    public Author Author;
}