namespace GamesStore.Persistence.IdTypes;

public record UserId : IdBase
{
    public UserId (Guid value) : base(value) { }

    public UserId() : base() { }
}
