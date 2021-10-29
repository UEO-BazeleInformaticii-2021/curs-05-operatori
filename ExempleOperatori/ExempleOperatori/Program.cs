using System;

namespace ExempleOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessageIfExists("message1", "alt message 1");
            PrintMessageIfExists(null, "alt message 2");
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
