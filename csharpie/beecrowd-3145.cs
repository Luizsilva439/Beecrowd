using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        double[] numbers = input.Select(x => double.Parse(x)).ToArray(); 
        double result = numbers[1] / (numbers[0] + 2);
        Console.WriteLine(result.ToString("F2").Replace(",","."));
    }
}