using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<double> numberList = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());

            if (number == 0)
                break;

            numberList.Add(number);
        }

        if (numberList.Count == 0)
        {
            Console.WriteLine("No numbers entered. Exiting...");
            return;
        }

        double sum = numberList.Sum();
        double average = sum / numberList.Count;
        double largest = numberList.Max();
        double smallestPositive = numberList.Where(x => x > 0).DefaultIfEmpty(-1).Min();

        numberList.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smallestPositive != -1)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers entered.");
        }

        Console.WriteLine("The sorted list is:");
        foreach (var number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}
