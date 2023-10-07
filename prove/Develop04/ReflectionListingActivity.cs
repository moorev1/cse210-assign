using System;
using System.Threading;

public class ReflectionListingActivity : MindfulnessActivity
{
    protected string[] prompts;
    protected string[] questions;

    protected void ShowPrompt()
    {
        string selectedPrompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"\nPrompt: {selectedPrompt}");
    }

    protected void AskQuestions(int duration)
    {
        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000);  // Pause for 2 seconds with a spinner animation
        }
    }
}
