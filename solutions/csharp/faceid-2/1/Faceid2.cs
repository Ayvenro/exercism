public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override int GetHashCode() => 
        (EyeColor, PhiltrumWidth).GetHashCode();

    public override bool Equals(object? obj) =>
        obj is FacialFeatures facialFeatures && 
        (facialFeatures.EyeColor, facialFeatures.PhiltrumWidth).Equals((EyeColor, PhiltrumWidth));
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override int GetHashCode() => 
        (Email, FacialFeatures).GetHashCode();

    public override bool Equals(object? obj) =>
        obj is Identity identity &&
        (identity.Email, identity.FacialFeatures).Equals((Email, FacialFeatures));
}

public class Authenticator
{
    private HashSet<Identity> _registeredIdentities = [];
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => 
        faceA.Equals(faceB);

    public bool IsAdmin(Identity identity)
    {
        var admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
        return admin.Equals(identity);
    }

    public bool Register(Identity identity) => 
        _registeredIdentities.Add(identity);

    public bool IsRegistered(Identity identity) => 
        _registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => 
        ReferenceEquals(identityA, identityB);
}
