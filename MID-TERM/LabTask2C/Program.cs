using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        int[][] marks = new int[n][];

        int maxMarks = 0;
        int topStudent = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.Write("Enter number of subjects for student " + (i + 1) + ": ");
            int sub = Convert.ToInt32(Console.ReadLine());

            marks[i] = new int[sub];
            int total = 0;

            for (int j = 0; j < sub; j++)
            {
                Console.Write("Enter marks for subject " + (j + 1) + ": ");
                marks[i][j] = Convert.ToInt32(Console.ReadLine());

                total = total + marks[i][j];
            }

            Console.WriteLine("Total marks of student " + (i + 1) + " is: " + total);

            
            if (total > maxMarks)
            {
                maxMarks = total;
                topStudent = i + 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Student " + topStudent + " got the highest marks: " + maxMarks);
    }
}