public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override int RecordProgress()
    {
        Completed = true;
        return Value;
    }
}
