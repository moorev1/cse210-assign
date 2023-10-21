public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public override void Display()
    {
        Console.WriteLine($"{name} - {description} (Completed {currentCount}/{targetCount} times)");
    }

    public override void Complete()
    {
        currentCount++;

        if (currentCount == targetCount)
        {
            Console.WriteLine($"Checklist Goal Completed: {name} (+{points} points)");
        }
        else
        {
            Console.WriteLine($"Checklist Goal Recorded: {name} (+{points} points)");
        }
    }
}
