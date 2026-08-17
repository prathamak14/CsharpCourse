//Find the largest among three numbers using nested if.

using System;
using System.ComponentModel;
using System.Transactions;

public class Classwork9
{
    public static void largestnumber3(){
    int num1;
    int num2;
    int num3;

    Console.WriteLine($"enter first numbers ");
    num1=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter a 2nd number");
    num2=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter a 3rd number");
    num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2 && num1 < num2)
        {
            Console.WriteLine($"{num1} is greter than {num2} and smaller than {num3}");
        }if(num2 > num1 && num2 < num3)
        {
            Console.WriteLine($"{num2} is greater than {num1}and smaller than {num3}");
        }
        else
        {
           Console.WriteLine($"all number is equal"); 
        } 
        
}
}