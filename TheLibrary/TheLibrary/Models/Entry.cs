namespace TheLibrary.Models;

public class Entry
{
    public Entry(string name, CheckoutStatus checkoutStatus=new CheckoutStatus(), string description="")
    {
        Name = name;
        Owner = owner;
        Borrower = borrower;
        Description = description;
    }
    
    /// The name of the entry
    public string Name { get; set; } = "no-name";
    /// A description of the entry
    public string Description { get; set; } = "";

    /// Who owns the entry
    public CheckoutStatus CheckoutStatus { get; set; }
}