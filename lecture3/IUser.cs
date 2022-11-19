namespace lecture1;

public interface IUser
{
    string Name { get; set; }
    void ChangeName(string newName);
}