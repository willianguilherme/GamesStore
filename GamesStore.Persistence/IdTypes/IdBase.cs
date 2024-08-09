namespace GamesStore.Persistence.IdTypes;

public abstract record IdBase
{
    private Guid _value;

    public IdBase(Guid value)
    {
        _value = value;
    }

    public IdBase()
    {
        _value = Guid.NewGuid();
    }

    public Guid ToGuid()
    {
        return _value;
    }

    public override string ToString()
    {
        return _value.ToString();
    }

    public bool IsEmpty()
    {
        return _value == Guid.Empty;
    }
}
