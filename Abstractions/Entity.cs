namespace Reviews.Abstractions;
// Интерфейс, от которого наследуется все сущности ( User & Feedback
public abstract class Entity
{
    public Guid Id { get; init;  } = Guid.NewGuid();

    public DateTime CreateTime { get; init; } = DateTime.Now;
    public DateTime UpdateTime { get; set; } = DateTime.Now;

}

