public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public static double Distance(Coord a, Coord b)
    {
        double dX = a.X - b.X;
        double dY = a.Y - b.Y;
        return (dX * dX) + (dY * dY);
    }
}

public struct Plot(Coord first, Coord second, Coord third, Coord fourth) : IEquatable<Plot>
{
    public Coord First = first, Second = second, Third = third,  Fourth = fourth;

    public double LongestSide
    {
        get
        {
            var s1 = Coord.Distance(First, Second);
            var s2 = Coord.Distance(Second, Third);
            var s3 = Coord.Distance(Third, Fourth);
            var s4 = Coord.Distance(Fourth, First);
            
            return Math.Max(Math.Max(s1,s2), Math.Max(s3,s4));
        }
    }

    public bool Equals(Plot other)
    {
        return First.Equals(other.First) && Second.Equals(other.Second) && Third.Equals(other.Third) && Fourth.Equals(other.Fourth);
    }

    public override bool Equals(object? obj)
    {
        return obj is Plot other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(First, Second, Third, Fourth);
    }
}


public class ClaimsHandler
{
    private List<Plot> _claimedPlots = [];
    
    public void StakeClaim(Plot plot) => 
        _claimedPlots.Add(plot);

    public bool IsClaimStaked(Plot plot) => 
        _claimedPlots.Contains(plot);

    public bool IsLastClaim(Plot plot) => 
        _claimedPlots.Last().Equals(plot);

    public Plot GetClaimWithLongestSide() => 
        _claimedPlots.MaxBy(x => x.LongestSide);
}
