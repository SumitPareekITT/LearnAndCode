public class Customer
{
    private string firstName;
    private string lastName;
    private Wallet myWallet;

    public Customer(string firstName, string lastName, double initialMoney)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.myWallet = new Wallet(initialMoney);
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public bool Pay(double amount)
    {
        return myWallet.Deduct(amount);
    }
}
