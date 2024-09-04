using System;
using System.Threading;

class Story
{
    static void Main()
    {
        game();
        Console.ReadLine();
    }

    static void game()
    {
        Console.WriteLine("Are we connected? [y/n]");
        string? ConnectedQ = Console.ReadLine()?.Trim().ToLower();

        if (ConnectedQ == "n")
        {
            Console.WriteLine("Are you sure that we are not connected? [yes I am sure/n]");
            string? SureQ = Console.ReadLine()?.Trim().ToLower();

            if (SureQ == "yes i am sure")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ok, your choice.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (SureQ == "n")
            {
                AskForName();
            }
            else
            {
                error();
            }
        }
        else if (ConnectedQ == "y")
        {
            AskForName();
        }
        else
        {
            error();
        }
    }

    static void AskForName()
    {
        Console.WriteLine("Good. What is your name?");
        string? name = Console.ReadLine()?.Trim().ToLower();

        Console.WriteLine("okay");
        shortPause();
        Console.WriteLine("Nice to meet you " + name);
        shortPause();
        Console.WriteLine("We are currently in limbo");
        longerPause();
        Console.WriteLine("A place beetwen life and death");
        longerPause();
        Console.WriteLine("You will have to choose a path, if you wanna return to your life before");
        longestPause();
        Console.WriteLine("or");
        shortPause();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("accept your death");
        longerPause();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("What do you do? [Return/accept/kill the narrator]");

        string? theChoice = Console.ReadLine()?.Trim().ToLower();
        if (theChoice == "return")
        {
            Console.WriteLine("your choice is done.");

            shortPause();
            Console.Clear();
            Console.WriteLine("You live the rest of your life in peace.");
            longerPause();
            Console.WriteLine("you eventually dies of old age");
            longerPause();
            Console.WriteLine("but suddenly");
            longerPause();
            Console.Clear();
            game();
        }
        else if (theChoice == "accept")
        {
            Console.WriteLine("your choice is done.");

            shortPause();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are dead");
            shortPause();
            Console.WriteLine("You feel nothing");
            longerPause();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("But suddenly");
            longerPause();
            Console.Clear();
            game();
        }
        else if (theChoice == "kill the narrator")
        {
            Console.WriteLine("your choice is to- WHAT.");
            shortPause();
            Console.WriteLine("HOW DARE YOU");
            shortPause();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The narrator kills you");
            longerPause();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You feel nothing");
            longerPause();
            Console.WriteLine("But suddenly");
            longerPause();
            Console.Clear();
            game();
        }
        else
        {
            error();
        }
    }

    static void shortPause()
    {
        Thread.Sleep(1000);
    }

    static void longerPause()
    {
        Thread.Sleep(2000);
    }

    static void longestPause()
    {
        Thread.Sleep(4000);
    }


    static void error()
    {
        Console.WriteLine("Remember to only type one of the options between the brackets ---> []");
        Console.WriteLine("Press 'r' to restart or any other key to exit.");

        var key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.R)
        {
            Console.Clear();
            game();
        }
        else
        {
            Console.WriteLine("Exiting the game.");
            Thread.Sleep(250);
            Console.WriteLine("3");
            Thread.Sleep(500);
            Console.WriteLine("2");
            Thread.Sleep(500);
            Console.WriteLine("1");
            Thread.Sleep(500);
            Environment.Exit(0);
        }
    }
}