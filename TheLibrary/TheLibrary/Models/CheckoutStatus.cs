using TheLibrary.Services;

namespace TheLibrary.Models;

public class CheckoutStatus
{
    public CheckoutStatus()
    {
        ConfigurationSettings settings = new ConfigurationSettings();
        Owner = settings.getDefaultOwner();
        Borrower = Owner;
    }

    public CheckoutStatus(Person owner)
    {
        Owner = owner;
        Borrower = owner;
    }
    public CheckoutStatus (Person owner, Person borrower)
    {
        Owner = owner;
        Borrower = borrower;
    }
    public Person Owner { get; set; }
    public Person Borrower { get; set; }
}