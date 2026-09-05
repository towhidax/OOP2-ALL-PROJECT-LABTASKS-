using System;
class programmA
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int sum1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int sum2= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition:  "+(sum1+sum2));
        Console.WriteLine("Subtraction: "+(sum1 - sum2));
        Console.WriteLine ("Multiplication:  "+ (sum1*sum2));
         if (sum2 != 0)
        {
            Console.WriteLine("Division: " + (sum1 / sum2));
        }
        else
        {
            Console.WriteLine("Division: Cannot divide by zero.");
            

        }
    }
}