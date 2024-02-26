using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] words = File.ReadAllLines("data/Words.txt");

        if (words.Length > 0)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, words.Length);

            Console.WriteLine("Random Word: " + words[randomIndex]);
        }
        else
        {
            Console.WriteLine("The file is empty or does not exist.");
        }
    }
}
