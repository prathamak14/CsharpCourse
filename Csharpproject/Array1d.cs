using System;

public class Array3
{
    public static  void Arraythree()
    {
         Console.WriteLine("enter how manu elements you want to store ");
         int size = Convert.ToInt32(Console.ReadLine());

         double[] arrayDouble= new double [size];

         Console.WriteLine("enter the element of arrya ");

         for(int i = 0 ; i < arrayDouble.Length; i++)
        {
           Console.WriteLine($"enter elemet  {i + 1}:");
            arrayDouble[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("the elements are ");
            foreach(double element in arrayDouble)  
        {
            Console.WriteLine(element);
        } 
    }
}