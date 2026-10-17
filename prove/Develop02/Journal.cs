using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;
using System.Text;

namespace JournalApp
{
    class Journal
    {
        private string JournalFile = "MyJournal.txt";
        public void Run()
        {
            Title = "Journal Application";
            DisplayIntro(); 
            CreateJournalFile();
            RunMenu();
            DisplayOutro();
        
        }

        private void RunMenu()
        {
            String choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case "1":
                        AddEntry();
                        break;
                    case "2":
                        DisplayJournalContents();
                        break;
                    case "3":
                        ClearFile();
                        break;
                    case "4":
                        DisplayOutro();
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Invalid choice. Please try again.");
                        WaitForKeyPress();
                        RunMenu(); 
                        break;
                }
            } while (choice != "4");
        }

        private string GetUserChoice()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Please select an option from the menu.");
            ForegroundColor = ConsoleColor.Black;
            WriteLine("=== Journal Menu ===");
            WriteLine("1. Add Entry");
            WriteLine("2. View Journal");
            WriteLine("3. Clear Journal");
            WriteLine("4. Exit");
            WriteLine("=====================");

            ForegroundColor = ConsoleColor.DarkBlue;
            string choice = ReadLine().Trim();
            ForegroundColor = ConsoleColor.Black;

            if (choice == "1")
            {
                AddEntry();
            }
            else if (choice == "2")
            {
                DisplayJournalContents();
            }
            else if (choice == "3")
            {
                ClearFile();
            }
            else if (choice == "4")
            {
                DisplayOutro();
                Environment.Exit(0);
            }
            else
            {
                WriteLine("Invalid choice. Please try again.");
                WaitForKeyPress();
                GetUserChoice(); 
            }

            return choice;
        }

        private void CreateJournalFile()
        {
            if (!File.Exists("JournalFile"))
            {
                File.Create("JournalFile").Close();  
            }
        }

        private void DisplayIntro() 
        {
            
            WriteLine("Welcome to the Journal Application");
            WaitForKeyPress();
        }

    

        private void DisplayOutro()
        {
            WriteLine("Thank you for using the Journal. Goodbye!");
            
        }

        private void DisplayJournalContents()
        {
            ForegroundColor = ConsoleColor.DarkMagenta;
            string journaltext = File.ReadAllText(JournalFile);
            WriteLine("\n=== Journal Contents ===");
            WriteLine(journaltext);
            WriteLine("========================");
            WaitForKeyPress();
           
        }

        private void ClearFile()
        {
            File.WriteAllText(JournalFile, string.Empty);
            WriteLine("Journal is cleared.");
            WaitForKeyPress(); 
        }

        private void AddEntry()
        {
            // Basic Version
            // WriteLine("What would you like to add?: ");
            //ForegroundColor = ConsoleColor.DarkMagenta;
            //string newLine = ReadLine();
            //File.AppendAllText(JournalFile, newLine + Environment.NewLine);
            //ForegroundColor = ConsoleColor.White;
            //WriteLine("Adding entry to the Journal");
            //WaitForKeyPress();

            // Advanced Version

            WriteLine("What would you like to add? (Type EXIT and press enter to stop.) ");
            ForegroundColor = ConsoleColor.DarkMagenta;
            
            string newLine = "";
            bool shouldContinue = true;
            while (shouldContinue)
            {
                string line = ReadLine();
                if (line.ToLower().Trim() == "exit")
                {
                    shouldContinue = false;
                }
                else
                {
                    newLine += line + Environment.NewLine;
                }
               
            }


            File.AppendAllText(JournalFile, newLine + Environment.NewLine);
            ForegroundColor = ConsoleColor.Black;
            WriteLine("Adding entry to the Journal");
            WaitForKeyPress();
        }

        private void WaitForKeyPress() 
        {
            WriteLine("Press any key to continue...");
            ReadKey(true);
        }

    }
}


