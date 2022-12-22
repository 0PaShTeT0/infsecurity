using System;
public class Prog_rnd
{
    public static void Main()
    {
        int seed;
        int n;
        int min;
        int max;
        int s;

        Console.Write("Write the number of numbers");
        Console.WriteLine();

        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write the max value of the numbers");
        Console.WriteLine();

        max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write the min value of the numbers");
        Console.WriteLine();

        min = Convert.ToInt32(Console.ReadLine());

        if (max < min)
        {
            s = max;
            max = min;
            min = s;
        }

        Console.Write("Write seed");
        Console.WriteLine();

        seed = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random(seed);

        for (int i = 0; i < n; i++)
        {
            if (i < n - 1)
            {
                Console.Write(rnd.Next(min, max) + ", ");
            }
            else
            {
                Console.Write(rnd.Next(min, max));
            }
            
        }
        Console.WriteLine();
    }
}
