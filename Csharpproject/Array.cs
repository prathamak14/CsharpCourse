// write a  program in c# to store number in 1d array from user and display their elements 

using System;
public class Array
{
    public static void DArray()
    {
        int[] number = new int[4];
        Console.WriteLine("enter 4 numbers ");
        for(int i = 0; i<4 ;i++)
        {
            Console.WriteLine("the number enter by user is" + (i+1) + ":");
            number[i]=Convert.ToInt32(Console.ReadLine());
        }  
        Console.WriteLine("you have enter");
     for(int  i=0; i<4 ; i++)
        {
            Console.WriteLine(number[i]);
        }
     }
}