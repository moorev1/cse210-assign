using System;
using System.Threading;

public class MindfulnessActivity
{
    protected string name;
    protected string description;

    public virtual void Start(int duration)
    {
        Console.WriteLine($"\n{name} Activity - {description}");
        Console.WriteLine($"Duration: {duration} seconds");
        PrepareToBegin();
        Thread.Sleep(2000);  // Pause for 2 seconds before starting
        PerformActivity(duration);
        FinishActivity(duration);
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine("Get ready to begin...");
    }

    protected virtual void FinishActivity(int duration)
    {
        Console.WriteLine($"\nGood job! You have completed the {name} activity.");
        Console.WriteLine($"Time spent: {duration} seconds");
        Thread.Sleep(3000);  // Pause for 3 seconds before finishing
    }

    protected virtual void PerformActivity(int duration)
    {
        // To be implemented in subclasses
    }
}
