namespace TheLibrary.Models;

public class CheckoutStatus
{
    public CheckoutStatus()
    {
        
    }
    public CheckoutStatus (Person owner, Person borrower)
    {
        
    }
    public Person Owner { get; set; }
    public Person Borrower { get; set; }
}