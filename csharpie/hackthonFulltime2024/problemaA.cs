using System;  
using System.Collections.Generic;  

class Program  
{  
    static void Main()  
    {  
        int numero = int.Parse(Console.ReadLine());  
        List<int> result = new List<int>();  
        
        for (int i = 0; i < numero; i++)  
        {  
            string[] vetor = Console.ReadLine().Split(' ');  
            int quantidade = int.Parse(vetor[0]);  
            int pulo = int.Parse(vetor[1]);  

            List<int> numbers = new List<int>();  

            // Inicializa a lista de números  
            for (int v = 0; v < quantidade; v++)  
            {  
                numbers.Add(v + 1);  
            }  

            // Executa a função e armazena o resultado  
            result.Add(Function(numbers, pulo));  
        }  

        // Exibe os resultados  
        for (int i = 0; i < numero; i++)  
        {  
            Console.WriteLine($"Case {i + 1}: {result[i]}"); // Correção para 1-based index  
        }  
    }  
   
    static int Function(List<int> lista, int pulo)  
    {  
        int index = 0;  

        // Continua até haver apenas um elemento na lista  
        while (lista.Count > 1)  
        {  
            // Atualiza o índice do elemento a ser removido  
            index = (index + pulo - 1) % lista.Count;  
            lista.RemoveAt(index); // Remove o elemento  
        }  

        return lista[0]; // Retorna o último elemento restante  
    }  
}  