using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example usage
        var scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life...");

        var game = new WordHidingGame(scripture);
        game.PlayGame();
    }
}

class Scripture
{
    public string Reference { get; }
    public string Text { get; }

    public List<Word> Words { get; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
}

class Word
{
    public string Text { get; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }
}

class WordHidingGame
{
    private readonly Scripture _scripture;

    public WordHidingGame(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void PlayGame()
    {
        while (true)
        {
            Console.Clear();
            DisplayScripture();

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            HideRandomWords();
        }
    }

    private void DisplayScripture()
    {
        Console.WriteLine($"Scripture Reference: {_scripture.Reference}\n");

        foreach (var word in _scripture.Words)
        {
            Console.Write(word.Hidden ? "--- " : $"{word.Text} ");
        }
    }

    private void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _scripture.Words.Count(word => !word.Hidden) + 1);

        for (int i = 0; i < wordsToHide; i++)
        {
            var hiddenWord = _scripture.Words.Where(word => !word.Hidden).OrderBy(_ => random.Next()).First();
            hiddenWord.Hidden = true;
        }
    }
}
