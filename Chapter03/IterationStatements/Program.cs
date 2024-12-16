#region Looping with the while statement
WriteLine("\n# Looping with the while statement\n");
int x = 0;
while (x < 10) WriteLine(x++);
#endregion

#region Looping with the do statement
WriteLine("\n# Looping with the do statement\n");
string? actualPasword = "holis";
string? password;
int errorCounter = 0;

do
{
  Write("Enter your password: ");
  // password = ReadLine();
  password = "holis";
}
while (actualPasword != password && ++errorCounter < 3);
if (errorCounter == 3)
{
  Write("Demsiados intentos fallidos.");
}
else
{
  Write("Correct!");
}
#endregion

#region Looping with the for statement
WriteLine("\n# Looping with the for statement\n");
for (int i = 0; i < 10; i++)
{
  WriteLine(i);
}
#endregion

#region Looping with the foreach statement
WriteLine("\n# Looping with the foreach statement\n");
string[] names = ["Adam", "Barry", "Charlie"];

foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters.");
}
#endregion
