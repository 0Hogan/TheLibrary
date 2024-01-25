namespace TheLibrary.Models;

public class Person
{
    public Person(string lastName, string firstName="", string middleNames="")
    {
        FirstName = firstName;
        MiddleNames = middleNames;
        LastName = lastName;
    }
    
    /// The first name of the person (if it is known)
    public string FirstName { get; set; } = "";
    /// The middle name(s) of the person (if it is known)
    public string MiddleNames { get; set; } = "";
    /// The last name of the person
    public string LastName { get; set; } = "no-name";
}