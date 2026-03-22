public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount x, CurrencyAmount y)
    {
        if (x.currency != y.currency) throw new ArgumentException();
        return x.amount == y.amount;
    }

    public static bool operator !=(CurrencyAmount x, CurrencyAmount y)
    {
        return !(x == y);
    }

    public static bool operator >(CurrencyAmount x, CurrencyAmount y)
    {
        if (x.currency != y.currency) throw new ArgumentException();
        return x.amount > y.amount;
    }

    public static bool operator <(CurrencyAmount x, CurrencyAmount y)
    {
        if (x.currency != y.currency) throw new ArgumentException();
        return x.amount < y.amount;
    }

    public static CurrencyAmount operator +(CurrencyAmount x, CurrencyAmount y)
    {
        if (x.currency != y.currency) throw new ArgumentException();
        return x with { amount = x.amount + y.amount };
    }
    
    public static CurrencyAmount operator -(CurrencyAmount x, CurrencyAmount y)
    {
        if (x.currency != y.currency) throw new ArgumentException();
        return x with { amount = x.amount - y.amount };
    }

    public static CurrencyAmount operator *(CurrencyAmount x, decimal y) =>
        x with { amount = x.amount * y };
    
    public static CurrencyAmount operator /(CurrencyAmount x, decimal y) =>
        x with { amount = x.amount / y };

    public static implicit operator double(CurrencyAmount x) =>
        (double)x.amount;
    
    public static implicit operator decimal(CurrencyAmount x) =>
        x.amount;
}
