public class RegularAccount : Account
{
    public RegularAccount(double balance)
    {
        Type = "Обычный";
        Balance = balance;
    }

    public override double Interest
    {
        get
        {
            double interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;

            if (Balance >= 1000)
                interest -= Balance * 0.4;

            return interest;
        }
    }
}
