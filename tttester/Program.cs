using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tttester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            crap();  
        }
        static void crap()
        {
            int choice = 0;
            string choice2;
            int ques;
            int answer = 0;
            string username;
            Random rng = new Random();
            Console.WriteLine("Welcome to times table tester!");
            Console.Write("\nEnter your name: ");
            username = Console.ReadLine();
            Console.WriteLine($"\nWhich times table do you want to be tested on {username}? (2-12)");
            choice = int.Parse(Console.ReadLine());
            int score = 0;
            var timer = new System.Diagnostics.Stopwatch();

            while (choice < 2 || choice > 12)
            {
                Console.WriteLine("Invalid Choice!");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice >= 2 || choice <= 12)
            {
                for (int i = 0; i < 10; i++)
                {
                    timer.Start();
                    int rannum = rng.Next(2, 12);
                    Console.WriteLine($"\nWhat is {choice} * {rannum}? ");
                    answer = int.Parse(Console.ReadLine());
                    ques = choice * rannum;


                    if (answer == ques)
                    {
                        Console.WriteLine("\nCorrect!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect!");
                    }
                }

            }
            timer.Stop();
            TimeSpan timetaken = timer.Elapsed;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nTime taken:{timetaken.TotalSeconds}s");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\nYou scored:{score}/10");

            if (score >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Excellent!");
            }
            if (score >= 4 && score < 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" Pretty good!");
            }
            if (score < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" More Practice needed!");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWould you like to play again?(y/n)");
            choice2 = Console.ReadLine();
            choice2 = choice2.ToLower();
            if (choice2 == "n")
            {
                return;
            }
            if (choice2 == "y")
            {
                Console.Clear();
                crap();
            }
        }
    }
}
