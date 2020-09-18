using System;

namespace CheckIdentifer
{
    public class Program
    {
        public static bool CheckIdentifier(string identifier)
        {
            if (identifier == "")
            {
                Console.WriteLine("Identifier can not be empty string.");
                return false;
            }
            else
            {
                for (int i = identifier.Length - 1; i >= 0; --i)
                {
                    if (char.IsDigit(identifier[i]))
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("Identifier contains only digits.");
                            return false;
                        }
                        continue;
                    }
                    else if (char.IsDigit(identifier[i]) && i == 0)
                    {
                        Console.WriteLine("Identifier can not start from number.");
                        return false;
                    }
                    else if (char.IsLetter(identifier[i]))
                    {
                        continue;
                    }
                    else if (!char.IsLetter(identifier[i]))
                    {
                        Console.WriteLine("The identifier contains neither a letter nor a number.");
                        return false;
                    }
                }
                return true;
            }
        }

        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid arguments count. \nUsage CheckIdentifer.exe <identifer>.");
            }
            else
            {
                string identifier = args[0];
                bool isIdentifier = CheckIdentifier(identifier);
                if (isIdentifier)
                {
                    Console.WriteLine("It can be identifier.");
                }
                else
                {
                    Console.WriteLine("It can't be identifier.");
                }

            }
        }
    }
}