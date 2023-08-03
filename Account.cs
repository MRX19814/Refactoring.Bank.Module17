public abstract class Account
{
    // тип учетной записи
    public string Type { get; protected set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public abstract double Interest { get; }
}
