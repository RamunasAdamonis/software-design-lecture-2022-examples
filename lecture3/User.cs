namespace lecture1;

public class User : UserBase, IUser
{
    public User(string name, DateTime dateOfBirth)
    {
        Id = Guid.NewGuid();
        Name = name;
        if (dateOfBirth >= DateTime.UtcNow)
            throw new Exception("your birthday cannot be in the future");
        DateOfBirth = dateOfBirth;
    }

    public Guid Id { get; private set; }
    public string Name { get; set; }

    public string GetGreeting()
    {
        return $"Hi {Name}, your id is: {Id}, your date of {DateOfBirth}";
    }

    public void ChangeName(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new Exception("Name cannot be empty");

        if (newName.Length < 3)
            throw new Exception("Name cannot be less than 3 symbols");

        Name = newName;
    }

}