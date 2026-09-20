using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        PromtUserBirthYear();
        
        
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to my program");
    }
    static void PromptUserName()
    {
        Console.Write("What is your full name?: ");
        string name = Console.ReadLine();
        
    }
    static void PromptUserNumber()
    {
        Console.Write("What is your Favorite Number?: ");
        int number = int.Parse(Console.ReadLine());
    }
    static void PromtUserBirthYear()
    {
        Console.Write("What Year were you born?: ");
        int birthyear = int.Parse(Console.ReadLine());
    }

    
}