using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
    
        double R = double.Parse(Console.ReadLine());
        double result = (2 * 3.14) * R;
        Console.WriteLine(result.ToString("F2").Replace(",","."));

    }
}