public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
        // Additional initialization for eternal goals, if needed
    }

    public override int RecordProgress()
    {
        // Eternal goals are never completed, so no progress to record
        return 0;
    }
}
