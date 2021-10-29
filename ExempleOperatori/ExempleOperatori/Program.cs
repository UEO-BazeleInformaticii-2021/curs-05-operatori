using System;

namespace ExempleOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("text abc");
        }

        static void Print(string text)
        {
            string parameterName = nameof(text);
            if (text is null)
            {
                Console.WriteLine($"The parameter {parameterName} was null");
            }
            else
            {
                Console.WriteLine($"{parameterName}={text}");
            }
        }

        static void PrintOddOrEven(int number)
        {
            bool isEven = number % 2 == 0;

            string message = isEven
                ? $"Number {number} is even"
                : $"Number {number} is odd";

            Console.WriteLine(message);
        }

        static void PrintIfInteger(object obj)
        {
            if (obj is int intValue)
            {
                Console.WriteLine($"The number is: {intValue}");
            }
        }

        static void PrintIfString(object obj)
        {
            string strValue = obj as string;
            if (strValue is not null)
            {
                Console.WriteLine($"The text is: {strValue}");
            }
        }

        static void PrintIfString2(object obj)
        {
            if (obj?.GetType() == typeof(string))
            {
                Console.WriteLine($"The text is: {obj}");
            }
        }

        static void PrintMessageIfExists(string message, string alternative)
        {
            string finalMessage = message ?? alternative;
            Console.WriteLine(finalMessage);

            // or
            /// message ??= alternative;
            /// Console.WriteLine(message);
        }
    }
}
