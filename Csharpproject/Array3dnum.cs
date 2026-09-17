using System;
using System.Data;
using System.Security.AccessControl;
public class Array3d{

public static void ThreeDarray()
{
    Console.WriteLine("enter a element you want to enter");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter the number of rows ");
    int row =Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter the number of colume ");
    int colume = Convert.ToInt32(Console.ReadLine());

    int[,,] array3D = new int [size , row , colume ];

    Console.WriteLine("enter tow values");
    
    for (int a = 0 ; a < size ; a++)
        {
            for ( int b = 0 ; b < size ; b++)
            {
                for (int c = 0 ; c < size ; c++)
                {
                    Console.WriteLine($"enter the value for [ {a} , {b} , {c}]");
                   
                }
            }
        }
    
    }
}