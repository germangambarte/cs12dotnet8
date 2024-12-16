using static System.Convert;
using System.Globalization;

#region Casting numbers implicitly and explicitly
WriteLine("\n# Casting numbers implicitly and explicitly\n");
int a = 10;
double b = a;
WriteLine($"a = {a}, b = {b}");

double c = 9.8;
int d = (int)c;
WriteLine($"c = {c}, d = {d}");

long e = 10;
int f = (int)e;
WriteLine($"e = {e:N0}, f = {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e = {e:N0}, f = {f:N0}");

e = 5_000_000_000_000;
f = (int)e;
WriteLine($"e = {e:N0}, f = {f:N0}");
#endregion

#region How negative numbers are represented in binary
WriteLine("\n# How negative numbers are represented in binary\n");
WriteLine("{0, 12} {1, 34}", "Decimal", "Binary");
WriteLine("{0, 12} {0, 34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
  WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);

#endregion

#region Converting with the System.Convert type
WriteLine("\n# Converting with the System.Convert type\n");
double[,] doubles = {
{ 9.49, 9.5, 9.51 },
{ 10.49, 10.5, 10.51 },
{ 11.49, 11.5, 11.51 },
{ 12.49, 12.5, 12.51 } ,
{ -12.49, -12.5, -12.51 },
{ -11.49, -11.5, -11.51 },
{ -10.49, -10.5, -10.51 },
{ -9.49, -9.5, -9.51 }
};
WriteLine($"| double | ToInt32 |");
WriteLine("--------------------");
for (int x = 0; x < 8; x++)
{
  for (int y = 0; y < 3; y++)
  {
    WriteLine($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7} |");
  }
  WriteLine("--------------------");
}
#endregion

#region Taking control of rounding rules
WriteLine("\n# Taking control of rounding rules\n");
WriteLine($"| double | ToInt32 |");
WriteLine("--------------------");
foreach (double n in doubles)
{
  double roundedNumber = Math.Round(n, digits: 0, mode: MidpointRounding.AwayFromZero);
  WriteLine($"| {n,6} | {roundedNumber,7} |");
}

#endregion

#region Converting from any type to a string
WriteLine("\n# Converting from any type to a string\n");
int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());
#endregion

#region TEST
WriteLine("\n# TEST\n");
byte[] binaryObject = new byte[128];
Random.Shared.NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
  Write($"{binaryObject[index]:X2} ");
}
WriteLine();

string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");
#endregion

#region Parsing from sitrngs to numbers or dates and times
WriteLine("\n# Parsing from sitrngs to numbers or dates and times\n");
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("9 July 1816");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}");
WriteLine($"My birthday is {birthday:D}");
#endregion

#region TryParse method
WriteLine("\n# TryParse method\n");
Write("Hoy amnu eggs are there?: ");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
  WriteLine($"There are {count} eggs.");
}
else
{
  WriteLine("I could no parse the input.");
}

#endregion
