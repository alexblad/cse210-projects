using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your grade percentage in this class? ");
        string answer= Console.ReadLine();
        int percent= int.Parse(answer);

        string letter = "";

        if (percent>89)
        {
            letter="A";
        }
        else if (percent>79)
        {
            letter="B";
        }
        else if (percent>69)
        {
            letter="C";
        }
        else if (percent>59)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent>69)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you goober, better luck next time!");
        }

    }
}