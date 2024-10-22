using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a password");
        string password = Console.ReadLine();

        bool validLength = false;
        bool containsUppercase = false;
        bool containsNumber = false;

        if (password.Length >= 8)
        {
            validLength = true;
        }

        for (int i = 0; i < password.Length; i++)
        {
            char character = password[i];

            if (char.IsUpper(character))
            {
                containsUppercase = true;
            }
            if (char.IsDigit(character))
            {
                containsNumber = true;
            }
        }

        if (validLength && (containsUppercase || containsNumber))
        {
            Console.WriteLine("Valid password");
        }
        else
        {
            Console.WriteLine("Invalid password It must be at least 8 characters long, and contain an uppercase letter or a number");
        }
    }
}