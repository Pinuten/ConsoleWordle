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
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, words.Length);
        return words[randomIndex];

    }

    static void Guesser()
    {
        string wordToGuess = GetRandomWord();
        Console.WriteLine(wordToGuess);
        int attemptsLeft = 6;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Welcome to Saltle!");
        Console.WriteLine("Try to guess the 5-letter word.");
        Console.WriteLine($"You have {attemptsLeft} attempts left.");
        while (attemptsLeft > 0)
        {
            Console.Write("\nEnter your guess: ");
            string guessedWord = Console.ReadLine().Trim().ToLower();

            if (guessedWord.Length != 5)
            {
                Console.WriteLine("Please enter a 5-letter word.");
                continue;
            }

            if (guessedWord == wordToGuess)
            {
                Console.WriteLine("\nCongratulations! You've guessed the word: " + wordToGuess);
                break;
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine("Incorrect guess. Attempts left: " + attemptsLeft);
                DisplayFeedback(wordToGuess, guessedWord);
            }
        }
        if (attemptsLeft == 0)
        {
            Console.WriteLine("\nSorry, you've run out of attempts. The word was: " + wordToGuess);
        }
    }
    static void DisplayFeedback(string wordToGuess, string guessedWord)
    {
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            if (wordToGuess[i] == guessedWord[i])
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write($"{guessedWord[i]}");
            }
            else if (wordToGuess.Contains(guessedWord[i]))
            {
                // doesnt work for multiple letters 
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write($"{guessedWord[i]}");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write($"{guessedWord[i]}");
            }
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("");
    }
}







