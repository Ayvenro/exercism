abstract class Character(string characterType)
{
    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior() : Character("Warrior")
{
    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard() : Character("Wizard")
{
    private bool _isSpellPrepared = false;

    public override int DamagePoints(Character target)
    {
        if (!_isSpellPrepared) return 3;
        _isSpellPrepared = false;
        return 12;
    }

    public override bool Vulnerable()
    {
        return !_isSpellPrepared;
    }

    public void PrepareSpell() => _isSpellPrepared = true;
}
