using System.Globalization;

partial class Program
{
    static int FunctionalFibonacci(uint term) => term switch
    {
        0 => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FunctionalFibonacci(term - 1) + FunctionalFibonacci(term - 2)
    };

    static void RunFunctionalFibonacci()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FunctionalFibonacci(term: i)
            );
            
        }
    }

    static int ImperativeFibonacci(uint term)
    {
        if (term == 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return ImperativeFibonacci(term - 1) + ImperativeFibonacci(term - 2);
        }
    }

    static void RunImperativeFibonacci()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: ImperativeFibonacci(term: i)
            );
        }
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(
                message: $"The factorial function is defined for non-negative integers only. Input: {number}",
                paramName: nameof(number)
            );
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static void RunFactorial()
    {
        for (int i = 0; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Pass a 32-bit unsigned integer and it will bbi converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2, 3, an so on.</param>
    /// <returns>Number as an ordinal value e.g 1st, 2nd, 3rd, and so on.</returns>
    static string CardinalToOrdinal(uint number)
    {
        uint lastToDigits = number % 100;
        switch (lastToDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th",
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 149; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }

        WriteLine();
    }

    static void ConfigureConsole(string culture = "es-AR", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }

        WriteLine($"Using culture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode.ToUpper() switch
        {
            "CH" => 0.08M,
            "HU" => 0.027M,
            "CA" => 0.0825M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.0M,
            _ => 0.06M,
        };
        return amount * rate;
    }

    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {number * row}");
        }

        WriteLine();
    }
}