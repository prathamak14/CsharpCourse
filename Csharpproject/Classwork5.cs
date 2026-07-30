//Input age and determine whether a person is eligible to vote (18 or above).

using System;

 class Classwork5
{
    public void Vote()
    {
        int age;

        Console.WriteLine($"enter your age ");
        age=Convert.ToInt32(Console.ReadKey());

        if(age >= 18)
        {
            Console.WriteLine($"your age is {age} elgible for voting ");
        }
        else
        {
            Console.WriteLine($"your age is {age} so your are not  elgible for voting "); 
        }
    }
}