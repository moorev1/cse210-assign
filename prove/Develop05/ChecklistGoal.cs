public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusValue { get; set; }

    public ChecklistGoal(string name, int value, int targetCount, int bonusValue) : base(name, value)
    {
        TargetCount = targetCount;
        BonusValue = bonusValue;
    }

    public override int RecordProgress()
    {
        CurrentCount++;

        if (CurrentCount == TargetCount)
        {
            Completed = true;
            return Value + BonusValue;
        }
        else
        {
            return Value;
        }
    }
}
