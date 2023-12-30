using Reviews.Abstractions;

namespace Reviews.Entityes;

public class User : Entity
{
    public string UserName { get; set; }
    public string? RealName { get; set; }

    public override string ToString() =>
         $"User {UserName} ({RealName ?? "None"}) | {Id}";
}
