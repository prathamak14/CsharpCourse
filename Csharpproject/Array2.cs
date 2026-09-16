// 
using System;

public class Array2
{
    public static void Doubledimwnsional()
    {
        Console.WriteLine("enter how many elements you want to store ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        string[] arrayString = new string[size];

        Console.WriteLine("enter the elements of array:");

        for (int i = 0; 1 < arrayString.Length; i++)
        {
            Console.WriteLine($"enter elemet  {i + 1}:");
            arrayString[i] = Console.ReadLine();
        }
        Console.WriteLine("Array elements are:");

        foreach (string element in arrayString)
        {
            Console.WriteLine(element);
        }
    }

}