namespace TheLibrary.Models;

public class Book : Entry
{
    public Book(string name, Author author, string owner="home", string borrower="home", string description="") : base(name, owner, borrower, description)
    {
        Author = author;
    }

    public Author Author;
}