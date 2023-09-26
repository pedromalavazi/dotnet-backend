namespace Domain.Entities;

public abstract class Entity : IEquatable<Entity>
{
    public Entity()
    {
        Id = Guid.NewGuid();
        CreateAt = DateTime.Now;
        UpdateAt = DateTime.Now;
    }

    public Guid Id { get; private set; }
    public DateTime CreateAt { get; private set; }
    public DateTime UpdateAt { get; private set; }

    public bool Equals(Entity? other)
    {
        if (other is null) return false;

        return Id == other.Id;
    }
}