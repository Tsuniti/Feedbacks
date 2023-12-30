using Reviews.Abstractions;
namespace Reviews.Entityes;

public class Feedback : Entity
{
    public Guid UserId { get; init; }
    public string Text { get; set; }
    public uint Rating { get; set; }

    public override string ToString() =>
        $"'{Text}' ({Rating}) | User id: {UserId}";
}
