using System;

class Question6
{
    public void Swapping()
    {
        int a = 14;
        int b = 7;


        a=b+a;
        b=a-b;
        a=a-b;

        Console.WriteLine($"the swapping value is a={a} and b={b}");
       
    }
}