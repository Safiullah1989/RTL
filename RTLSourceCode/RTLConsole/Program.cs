using System;

namespace RTLConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static void Login()
        {
            Console.Write("Enter User Name:");
            var userName = Console.ReadLine();
            Console.WriteLine(userName);

            Console.Write("Enter Password:");
            var password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            Console.WriteLine();
            Console.WriteLine(password);

        }
    }
}
