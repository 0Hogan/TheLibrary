namespace TheLibrary.Models;

public class Entry
{
    public Entry(string name, string description="")
    {
        Name = name;
        Description = description;
    }

    public Entry(string name, CheckoutStatus checkoutStatus, string description = "")
    {
        Name = name;
        CheckoutStatus = checkoutStatus;
        Description = description;
    }
    
    /// The name of the entry
    public string Name { get; set; }
    /// A description of the entry
    public string Description { get; set; }

    /// Who owns the entry
    public CheckoutStatus CheckoutStatus { get; set; } = new CheckoutStatus();
}