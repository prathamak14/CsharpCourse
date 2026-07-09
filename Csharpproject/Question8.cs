using System;
using System.Data;
using System.Runtime.CompilerServices;

class Question8
{
    public void Simpleintrest()
    {
      double   principal = 1000;
      double rate = 10;
      double time = 3;

      double simpleintrest = principal*time*rate/100;

        Console.WriteLine($"the simpleintrest is {simpleintrest}");
    }

}
