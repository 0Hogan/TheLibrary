using TheLibrary.Services;

namespace TheLibrary.Models;

public class CheckoutStatus
{
    public CheckoutStatus()
    {
        ConfigurationSettings settings = new ConfigurationSettings();
        Owner = settings.GetDefaultOwner();
        Borrower = null;
    }

    public CheckoutStatus(Person owner)
    {
        Owner = owner;
        Borrower = null;
    }
    public CheckoutStatus (Person owner, Person borrower)
    {
        Owner = owner;
        Borrower = borrower;
    }
    /// The person who owns the entry.
    public Person Owner { get; set; }
    /// The person who is currently borrowing the entry. (A null borrower indicates that the entry is not currently checked out).
    public Person? Borrower { get; set; }
}