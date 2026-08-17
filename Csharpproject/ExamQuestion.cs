 
//2. Write a C# program to input the salary of 8 employees.
// // Calculate the bonus according to the following rules: 
//Salary   Bonus 
//Less than Rs. 20,000  20% 
//Rs. 20,000–39,999  15% 
//Rs. 40,000–59,999  10% 
//Rs. 60,000 and above 5% 
 //Display the salary, bonus amount, and total salary after adding the bonus.

 using System;
 class ExamQuestion
{
    public  void Question()
    {
        double salary ;
        double bonus ;
        double totalsalary;

        for (int employeei = 1 ; employeei<=8; employeei++)
        {
             Console.WriteLine("employee id"+ employeei );

            Console.WriteLine($"enter you basic salery ");
            salary=Convert.ToDouble(Console.ReadLine());

            if(salary < 20000)
            {
                bonus = salary *20 / 100;
            }
            else if (salary < 40000)
            {
                bonus = salary *15 / 100;
            }
            else if (salary < 60000)
            {
                bonus = salary *10 / 100;
            }
            else
            {
                bonus = salary *5 / 100;
            }

            totalsalary= salary + bonus;

            Console.WriteLine("salary ="+ salary);
            Console.WriteLine("bonus="+ bonus);
            Console.WriteLine("total salary ="+ totalsalary);

        }
 
    }
}