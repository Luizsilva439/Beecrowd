using System;
using System.Linq;

class URI{
    static void Main(string[] args){
    
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = input.Select(x => int.Parse(x)).ToArray();

        int aliados = numbers[0] + numbers[1] + numbers[2] + numbers[5];
        int enemigos = numbers[3] + numbers[4];

        if (aliados > enemigos){
            Console.WriteLine("Middle-earth is safe.");
        }else{
            Console.WriteLine("Sauron has returned.");
        }

    }
}