using System.Xml;

object height = 1.88;
object name = "German";
Console.WriteLine($"{name} is {height} metres tall.");

// int length = name.Length;
int lenght = ((string)name).Length;

Console.WriteLine($"{name} has {lenght} characters.");

Console.WriteLine($"\n{new string('-', count: 25)}\n");

dynamic something;

something = new[] { 3, 5, 7 };
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"The type of something is {something.GetType()}\n");

something = 12;
// Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"The type of something is {something.GetType()}\n");

something = "Algo";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"The type of something is {something.GetType()}\n");

Console.WriteLine($"\n{new string('-', count: 25)}\n");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");