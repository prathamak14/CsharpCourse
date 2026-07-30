using System;

class Question9
{
    public void Marks()
    {
        int physics  = 85;
        int chemistry  = 90;
        int math = 78;
        int nepali  = 88;
        int english = 95;

        double average = (math + english + nepali  + chemistry + physics) / 5.0;
        
         Console.WriteLine("nepali " + nepali);
        Console.WriteLine("english " + english);
        Console.WriteLine("math: " + math);
        Console.WriteLine("chemistry: " + chemistry);
        Console.WriteLine("physics : " + physics);
        Console.WriteLine("Average Marks = " + average);
    }
}