class WeighingMachine(int precision)
{
    public int Precision { get; } = precision;

    public double Weight
    {
        get;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            field = value;
        }
    }

    public double TareAdjustment { get; set; } = 5.0;

    public string DisplayWeight => string.Format("{0:F" + precision + "} kg", Weight - TareAdjustment);
}
