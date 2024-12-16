﻿#region Branching with the id statement
using SelectionStatements;

Console.WriteLine("\n# Branching with the id statement\n");
string password = "ninja";
if (password.Length < 8)
{
  Console.WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
  Console.WriteLine("Your password is strong.");
}
#endregion

#region Pattern matching with the if statement
Console.WriteLine("\n# Pattern matching with the if statement\n");
object o = "3";
int j = 4;
if (o is int i)
{
  Console.WriteLine($"{i} x {j} = {i * j}");
}
else
{
  Console.WriteLine("o is not an int so it cannot multiply");
}
#endregion

#region Branching with the switch statement
Console.WriteLine("\n# Branching with the switch statement\n");
// Inclusive lower bound but exclusive upper bound.
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
Console.WriteLine($"My random number is {number}");
switch (number)
{
  case 1:
    Console.WriteLine("One");
    break; // Jumps to end of switch statement.
  case 2:
    Console.WriteLine("Two");
    goto case 1;
  case 3: // Multiple case section.
  case 4:
    Console.WriteLine("Three or four");
    goto case 1;
  case 5:
    goto A_label;
  default:
    Console.WriteLine("Default");
    break;
} // End of switch statement.
Console.WriteLine("After end of switch");
A_label:
Console.WriteLine($"After A_label");
#endregion

#region Pattern matching with the swith statement
Console.WriteLine("\n# Pattern matching with the swith statement\n");
var animals = new Animal?[]{
  new Cat{Name="Karen", Born = new(year:2022,month:8,day:23), Legs = 4, IsDomestic = true},
  new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12) },
  new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true},
  new Spider { Name = "Captain Furry", Born = DateTime.Today }
};
foreach (Animal? animal in animals)
{
  string message;
  switch (animal)
  {
    case Cat { Legs: 4 } fourLeggedCat:
      message = $"The cat named {fourLeggedCat.Name} has four legs.";
      break;
    case Cat wildCat when wildCat.IsDomestic == false:
      message = $"The non-domestic cat is named {wildCat.Name}.";
      break;
    case Cat cat:
      message = $"The cat is named {cat.Name}.";
      break;
    default: // default is always evaluated last.
      message = $"{animal.Name} is a {animal.GetType().Name}.";
      break;
    case Spider spider when spider.IsPoisonous:
      message = $"The {spider.Name} spider is poisonous. Run!";
      break;
    case null:
      message = "The animal is null.";
      break;
  }
  Console.WriteLine($"switch statement: {message}");
}
#endregion

#region Simplifying switch statements with switch expressions
Console.WriteLine("\n# Simplifying switch statements with switch expressions\n");
foreach (Animal? animal in animals)
{
  string message = animal switch
  {
    Cat { Legs: 4 } fourLeggedCat => $"The cat named {fourLeggedCat.Name} has four legs.",
    Cat { IsDomestic: false } wildCat => $"The non-domestic cat is named {wildCat.Name}.",
    Cat cat => $"The cat is named {cat.Name}.",
    Spider { IsPoisonous: true } spider => $"The {spider.Name} spider is poisonous. Run!",
    null => "The animal is null.",
    _ => $"{animal.Name} is a {animal.GetType().Name}."
  };
  Console.WriteLine(message);
}
#endregion