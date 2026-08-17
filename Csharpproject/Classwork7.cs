using System;

class Classwork7
{
    public static void Divisible2()
    {
        int num;

        Console.WriteLine("Enter a number:");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0 && num % 11 == 0)
        {
            Console.WriteLine($"{num} is divisible by both 5 and 11.");
        }
        else
        {
            Console.WriteLine($"{num} is not divisible by both 5 and 11.");
        }
    }
}