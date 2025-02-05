namespace Upcasting.Properties;

public class BusinesAccount : Account
{
    public double LoanLimit { get; set; }

    public BusinesAccount()
    {
        
    }

    public BusinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if (amount <= LoanLimit)
        {
            Balance += amount;
        }
    }
}