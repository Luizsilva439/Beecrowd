using System;  

class Program  
{  
    static void Main()  
    {  
        string line;  
        while ((line = Console.ReadLine()) != null)  
        {  
            Console.WriteLine(ToDancingSentence(line));  
        }  
    }  

    static string ToDancingSentence(string input)  
    {  
        char[] result = new char[input.Length];  
        bool isUpper = true; 
        int index = 0;  

        foreach (char ch in input)  
        {  
            if (char.IsLetter(ch))  
            {  
                if (isUpper)  
                {  
                    result[index++] = char.ToUpper(ch);  
                }  
                else  
                {  
                    result[index++] = char.ToLower(ch);  
                }  
                isUpper = !isUpper; 
            }  
            else  
            {  
                result[index++] = ch; 
            }  
        }  

        return new string(result);  
    }  
}  