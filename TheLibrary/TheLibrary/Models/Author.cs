namespace TheLibrary.Models;

public class Author : Person
{
    public Author(string lastName, string firstName = "", string middleNames = "") 
         : base(lastName, firstName, middleNames)
    {
        
    }
}