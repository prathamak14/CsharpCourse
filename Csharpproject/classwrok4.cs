//## 4. Smallest of Two Numbers

//Write a program to find the smaller of two numbers.

using System;

class Classwork4
{
    public void Smallest()
    {
        int num1;
        int num2;

        Console.WriteLine($"enter a number ");
        num1= Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine($"enter another  number ");
        num2= Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
             Console.WriteLine($"second number is smaller   ");
        }
        else
        {
             Console.WriteLine($"first number is smaller ");
        }
    }
}