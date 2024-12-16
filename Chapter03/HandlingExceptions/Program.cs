#region Wrapping error-prone code in a try block
WriteLine("\n# Wrapping error-prone code in a try block\n");
WriteLine("Before parsing");
Write("Whats is your age?: ");
// string? input = ReadLine();
string input = "26";

try
{
  int age = int.Parse(input!);
  WriteLine($"You are {age} years old.");
}
catch (FormatException)
{
  WriteLine("The age you entered is not a valid number format.");
}
catch (OverflowException)
{
  WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (Exception ex)
{
  WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After Parsing");
#endregion

#region Catching with filters
WriteLine("\n# Catching with filters\n");
Write("enter an amount: ");
// string? amount = ReadLine();
string amount = "32";
if (string.IsNullOrEmpty(amount)) return;

try
{
  decimal amountValue = decimal.Parse(amount);
  WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
  WriteLine("Amounts cannot use te dollar sign!");
}
catch (FormatException)
{
  WriteLine("Amounts must only contain digits!");
}

#endregion

#region Checked statement
WriteLine("\n# Checked statement\n");
try
{
  checked
  {
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
  }
}
catch (OverflowException)
{
  WriteLine("The code overflowed but I caught the exception.");
}
#endregion

#region Unchecked statement
WriteLine("\n# Unchecked statement\n");
unchecked
{
  int y = int.MaxValue + 1;
  WriteLine($"Initial value: {y}");
  y--;
  WriteLine($"After decrementing: {y}");
  y--;
  WriteLine($"After decrementing: {y}");
}

#endregion
