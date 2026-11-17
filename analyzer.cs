using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a number. ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("even.");
        else
            Console.WriteLine("odd.");

        if (number > 0)
            Console.WriteLine("positive.");
        else if (number < 0)
            Console.WriteLine("negative.");
        else
            Console.WriteLine("zero.");
    }
}
