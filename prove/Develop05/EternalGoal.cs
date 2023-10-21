public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void Complete()
    {
        Console.WriteLine($"Eternal Goal Recorded: {name} (+{points} points)");
    }
}
