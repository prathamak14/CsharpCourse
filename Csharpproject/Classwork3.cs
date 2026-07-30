//Input two integers and display the larger on
using System;

class Classwork3
{
    public void Larger()
    {
        int num1;
        int num2;

          Console.WriteLine("enter a number");
num1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("enter a number");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
        {
             Console.WriteLine($"first number is greater  ");
        }
        else
        {
             Console.WriteLine($"second number is greater  ");
        }
    }
}