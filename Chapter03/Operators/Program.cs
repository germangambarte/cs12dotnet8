#region Exploring unary operators
Console.WriteLine("\n# Exploring unary operators\n");
int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b}");
int c = 3;
int d = ++c; // Prefix means increment c before assigning it.
Console.WriteLine($"c is {c}, d is {d}");
#endregion

#region Exploring binary arithmetic operators
Console.WriteLine("\n# Exploring binary arithmetic operators\n");
int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f = {g / f}");
#endregion

#region Exploring null-coalescing operator
// Console.WriteLine("\n# Exploring null-coalescing operator\n");
// string? authorName = Console.ReadLine();
// int maxLength = authorName?.Length ?? 0;
// authorName ??= "unknown";
#endregion

#region Exploring logical operators
Console.WriteLine("\n# Exploring logical operators\n");
bool p = true;
bool q = false;
Console.WriteLine($"AND  | p     | q    ");
Console.WriteLine($"p    | {p & p,-5} | {p & q,-5} ");
Console.WriteLine($"q    | {q & p,-5} | {q & q,-5} ");
Console.WriteLine();

Console.WriteLine($"OR   | p     | q    ");
Console.WriteLine($"p    | {p | p,-5} | {p | q,-5} ");
Console.WriteLine($"q    | {q | p,-5} | {q | q,-5} ");
Console.WriteLine();

Console.WriteLine($"XOR  | p     | q    ");
Console.WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5} ");
Console.WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5} ");
#endregion

#region Exploring conditional logical operators
Console.WriteLine("\n# Exploring conditional logical operators\n");
static bool DoStuff()
{
  Console.WriteLine("I am doing some stuff.");
  return true;
}
Console.WriteLine($"p & DoStuff() = {p & DoStuff()}");
Console.WriteLine($"q & DoStuff() = {q & DoStuff()}");
Console.WriteLine();
Console.WriteLine($"p && DoStuff() = {p && DoStuff()}");
Console.WriteLine($"q && DoStuff() = {q && DoStuff()}");
#endregion

#region Exploring bitwise and binary shift operators
Console.WriteLine("\n# Exploring bitwise and binary shift operators\n");
int x = 10;
int y = 6;
Console.WriteLine($"Expression | Decimal | Binary");
Console.WriteLine($"-------------------------------");
Console.WriteLine($"x          | {x,7} | {x:B8}");
Console.WriteLine($"y          | {y,7} | {y:B8}");
Console.WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
Console.WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
Console.WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");
Console.WriteLine();
Console.WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}");
Console.WriteLine($"x * 8      | {x * 8,7} | {x * 8:B8}");
Console.WriteLine($"y >> 1     | {y >> 1,7} | {y >> 1:B8}");
#endregion
