using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;
        

        

        while (num != 0)
        
        {
            Console.Write("input a number, press 0 to quit ");
            
            string usernum = Console.ReadLine();
            num = int.Parse(usernum);
            
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; 
        }

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {             
                max = number;
            }
        }

        double average = numbers.Average();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The max number is {max}");
        Console.WriteLine($"The Average is {average}");
        
        
        
        
        
        
        
    }
}