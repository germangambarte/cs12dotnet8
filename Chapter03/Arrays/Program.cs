#region Working with single-dimensional arrays
WriteLine("\n# Working with single-dimensional arrays\n");
string[] array;
array = new string[4];
array[0] = "Kate";
array[1] = "Jack";
array[2] = "Rebecca";
array[3] = "Tom";

for (int i = 0; i < array.Length; i++)
{
  WriteLine($"array[{i}]: {array[i]}");
}
string[] arrayInitializer = ["Kate", "Jack", "Rebebba", "Tom"];

WriteLine();

for (int i = 0; i < arrayInitializer.Length; i++)
{
  WriteLine($"arrayInitializer[{i}]: {arrayInitializer[i]}");
}

#endregion

#region Working with multi-dimensional arrays
WriteLine("\n# Working with multi-dimensional arrays\n");
string[,] grid1 = {
  {"Alpha", "Beta", "Gamma", "Delta"},
  {"Anne", "Ben", "Charlie", "Doug"},
  {"Aardvark", "Bear", "Cat", "Dog"},
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

WriteLine();

for (int i = 0; i <= grid1.GetUpperBound(0); i++)
  for (int j = 0; j <= grid1.GetUpperBound(1); j++)
    WriteLine($"Row {i}, Column: {j}: {grid1[i, j]}");

#endregion

#region Working with jagged arrays
WriteLine("\n# Working with jagged arrays\n");
string[][] jagged = [
  ["Alpha", "Beta", "Gamma"],
  ["Anne", "Ben", "Charlie", "Doug"],
  ["Aardvark", "Bear"],
];

WriteLine($"Upper bound of the array of arrays is: {jagged.GetUpperBound(0)}");

for (int arr = 0; arr <= jagged.GetUpperBound(0); arr++)
{
  WriteLine($"Upper bound of array {arr}: {jagged[arr].GetUpperBound(0)}");
}

WriteLine();

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
    WriteLine($"Row {row}, Column: {col}: {jagged[row][col]}");
#endregion

#region List pattern matching with arrays
WriteLine("\n# List pattern matching with arrays\n");
int[] sequentialNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int[] oneTwoNumbers = [1, 2];
int[] OneTwoTenNumbers = [1, 2, 10];
int[] OneTwoThreeTenNumbers = [1, 2, 3, 10];
int[] primeNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];
int[] fibonacciNumbers = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89];
int[] emptyNumbers = [];
int[] threeNumbers = [9, 7, 5];
int[] sixNumbers = [9, 7, 5, 4, 2, 10];

WriteLine($"{nameof(sequentialNumbers)}: {ChechSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {ChechSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(OneTwoTenNumbers)}: {ChechSwitch(OneTwoTenNumbers)}");
WriteLine($"{nameof(OneTwoThreeTenNumbers)}: {ChechSwitch(OneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {ChechSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {ChechSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {ChechSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {ChechSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {ChechSwitch(sixNumbers)}");

static string ChechSwitch(int[] values) => values switch
{
[] => "Empty array",
[1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
[1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
[1, 2] => "Contains 1 then 2.",
[int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
[0, _] => "Starts with 0, then one other number.",
[0, ..] => "Starts with 0, then any range of numbers.",
[2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
[..] => "Any items in any order",
};

#endregion
