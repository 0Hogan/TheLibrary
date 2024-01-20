namespace TheLibrary.Models;

public class Person
{
    public Person(string lastName, string firstName="", string middleNames="")
    {
        FirstName = firstName;
        MiddleNames = middleNames;
        LastName = lastName;
    }
    
    public string FirstName { get; set; } = "";
    public string MiddleNames { get; set; } = "";
    public string LastName { get; set; } = "no-name";
}