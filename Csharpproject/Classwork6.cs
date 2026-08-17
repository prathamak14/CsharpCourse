//Check whether a number is divisible by 5.

using System;

class Classwork6
{
    public static void Divisible()
    {
        int num;

        Console.WriteLine($"enter a number ");
        num=Convert.ToInt32(Console.ReadLine());

        if(num%5 == 0){
        Console.WriteLine($"The {num} is divisible by 5 ");
        }
        else{
        Console.WriteLine($"the number is not divisible by 5");

    }
}
}