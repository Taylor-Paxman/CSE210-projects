using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random r = new Random();
        int winnum = r.Next(0,100);
        bool win = false;
        
        do
        {
            Console.WriteLine("Guess a number between 0 and 100: ");
            string s = Console.ReadLine();
            int i = int.Parse(s);

            if ( i > winnum)
            {
                Console.WriteLine("to high! guess lower");
            }
            else if ( i < winnum)
            {
                Console.WriteLine("to low! guess higher");
            }
            else if ( i == winnum)
            {
                Console.WriteLine("You Win!!!");
            }

            Console.WriteLine();
        } while(win == false);
    }   
}


