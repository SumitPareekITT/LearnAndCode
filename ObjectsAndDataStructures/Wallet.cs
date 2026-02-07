public class Wallet
{
    private double balance;

    public Wallet(double initialAmount)
    {
        balance = initialAmount;
    }

    public bool Deduct(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
}
