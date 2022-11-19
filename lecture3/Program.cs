// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using lecture1;


var rick = new User(name: "Rick", dateOfBirth: new DateTime(2000, 1, 1));
var john = new User(name: "John", dateOfBirth: new DateTime(2022, 1, 1));

// Console.WriteLine(john.Name);

// john.Name = "new Name";

// john.ChangeName(null);

var morty = new User(name: "Morty", dateOfBirth: new DateTime(2005, 1, 1));
var adminMorty = new AdminUser(name: "Admin Morty", dateOfBirth: new DateTime(2005, 1, 1));


var users = new List<IUser>
{
    morty,
    adminMorty
};


foreach (var user in users)
    user.ChangeName(user.Name + "_2");


Console.WriteLine(morty.GetGreeting());
Console.WriteLine(adminMorty.GetGreeting());


