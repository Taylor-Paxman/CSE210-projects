using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Ask the User their grade Percentage

        Console.Write("What is your grade percentage? ");
        string valuefromuser = Console.ReadLine();
        int percent = int.Parse(valuefromuser);
        string letter = "";

        if (percent >= 90)
        {
        letter = "A-";
             if (percent >= 93)
            {
            letter = "A";     
                 if (percent >= 97) 
                {
                    letter = "A+";
                }
            } 
        }
    
        else if (percent >= 80)
        {
        letter = "B-";
            if (percent >= 83)
            {
            letter = "B";
                if (percent >= 87)
                {
                 letter = "B+";   
                } 
             }
        }

        else if (percent >= 70)
        {
            letter = "C";
            // Console.WriteLine($"Your Grade is: {letter}, You passed ");
            }

        else if (percent >= 60)
        {
            letter = "D";
            // Console.WriteLine($"Your Grade is: {letter}, Sorry Better Try again ");
        
            }

        else 
        {
            letter = "F";
            
            // Console.WriteLine($"Your Grade is: {letter}, You FAILED ");
            }
        
        if (percent >= 70)
        {
            Console.WriteLine($"Your Grade is: {letter}, You passed ");
        }
        else

        {
          Console.WriteLine($"Your Grade is: {letter}, You FAILD, Better try again ");
          
        }


        
        
            
            
        

    

        
            
       
        

    





    }
}