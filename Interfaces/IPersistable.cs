namespace Reviews.Interfaces;

public interface IPersistable
{
    void SaveToFile();
    void LoadFromFile();
}
