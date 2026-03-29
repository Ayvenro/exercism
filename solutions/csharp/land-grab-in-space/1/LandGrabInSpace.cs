public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot(Coord first, Coord second, Coord third, Coord fourth) : IEquatable<Plot>
{
    public Coord First = first, Second = second, Third = third,  Fourth = fourth;

    public int LongestSide
    {
        get
        {
            int minX = Math.Min(Math.Min(First.X, Second.X), Math.Min(Third.X, Fourth.X));
            int maxX = Math.Max(Math.Max(First.X, Second.X), Math.Max(Third.X, Fourth.X));
            int minY = Math.Min(Math.Min(First.Y, Second.Y), Math.Min(Third.Y, Fourth.Y));
            int maxY = Math.Max(Math.Max(First.Y, Second.Y), Math.Max(Third.Y, Fourth.Y));
            
            return Math.Max(maxX - minX, maxY - minY);
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
