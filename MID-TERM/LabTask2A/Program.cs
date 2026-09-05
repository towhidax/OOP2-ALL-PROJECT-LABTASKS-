using System;

class ProgramA
{
    static void Main()
    {
        
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        
        Console.WriteLine($"Enter {size} elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        int max = arr[0]; 

        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i]; 
            }
        }

        Console.WriteLine("The largest element is: " + max);
    }
}