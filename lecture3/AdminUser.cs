namespace lecture1;

public class AdminUser : UserBase, IUser
{
    public AdminUser(string name, DateTime dateOfBirth)
    {
        Id = Guid.NewGuid();
        Name = name;
        if (dateOfBirth >= DateTime.UtcNow)
            throw new Exception("your birthday cannot be in the future");
        DateOfBirth = dateOfBirth;

    }

    public Guid Id { get; private set; }
    public string Name { get; set; }
    public bool HasAllPermission { get; private set; }

    public string GetGreeting()
    {
        return $"Hi {Name}, your id is: {Id}, your date of {DateOfBirth}";
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

}