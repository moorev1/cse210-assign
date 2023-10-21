using System;

public class Goal
{
    private string name;
    private string description;
    protected int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{name} - {description}");
    }

    public virtual void Complete()
    {
        Console.WriteLine($"Goal Completed: {name} (+{points} points)");
    }
}
