// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Otra vez: Hello, World!");


var user = new User("Enrique","Diaz");


Console.WriteLine(user.Fullname());

Console.WriteLine(user.Name);
user.Name = "Facundo";
Console.WriteLine($"Luego del cambio de nombre, queda: {user.Name}");
//36 minutos