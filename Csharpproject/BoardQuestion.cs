/*15. Write a C# program that calculates and displays the final grade of the four students based on their 
exam score. The program should read the "Name" and "Exam Score" from the user. 
Also calculate the final grade of each student and display their information as mentioned:

i. Student Name
ii. Exam Score
iii. Final Grade

The letter grades are assigned as below:
| Grade | A      | B     | C     | D     | F        |
| ----- | ------ | ----- | ----- | ----- | -------- |
| Score | 90–100 | 80–89 | 70–79 | 60–69 | Below 60 | */

using System;
using System.Net;
using System.Transactions;

public class BoardQuestion
{
    public void  Board()
    {
        string name ;
        double marks ;
        string grade ;

        for(int student = 1 ; student <=4; student++ ){

      
        Console.WriteLine("student name"+ student );

        Console.WriteLine($"enter your name ");
        name=Convert.ToString(Console.ReadLine());

        marks=Convert.ToDouble(Console.ReadLine);
        Console.WriteLine($"enter your marks ");

        if (marks <=90 )
        {
         Console.WriteLine($"your garde is A");
        }else if ( marks <=80 )
        {
            Console.WriteLine($"your garde is B"); 
        }else if ( marks <= 70)
        {
             Console.WriteLine($"your garde is C");
        }else if (marks <= 60)
        {
             Console.WriteLine($"your garde is D");
        }
        else
        {
             Console.WriteLine($"your garde is F");
        }
        

}
    }
}
