using System;

class ProgramB
{
    static void Main()
    {
        
        Console.Write("Enter a number: ");
        int sum = Convert.ToInt32(Console.ReadLine());

        if (sum > 0)
        {
         Console.WriteLine("The number is positive");
        }
        else if (sum < 0)
        {
          Console.WriteLine("The number is negative");
        }
        else
        {
          Console.WriteLine("The number is zero");
        }
    }
}