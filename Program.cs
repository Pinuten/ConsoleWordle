using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Guesser();
    }

    static string GetRandomWord()
    {
        string[] words = File.ReadAllLines("data/Words.txt");

        if (words.Length > 0)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, words.Length);
            return words[randomIndex];
        }
        else
        {
            Console.WriteLine("The file is empty or does not exist.");
            return "hej hej ";
        }
    }

    static void Guesser()
    {
        string WordToGuess = GetRandomWord();
        Console.WriteLine(WordToGuess);
        int maxAttemptes = 5;
        char[] wordDisplay = new char[WordToGuess.Length];
        for (int i = 0; i < WordToGuess.Length; i++)
        {
            wordDisplay[i] = '_';
        }
    }
}
