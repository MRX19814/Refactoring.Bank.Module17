public class SalaryAccount : Account
{
    public SalaryAccount(double balance)
    {
        Type = "Зарплатный";
        Balance = balance;
    }

    public override double Interest
    {
        get { return Balance * 0.5; }
    }
}