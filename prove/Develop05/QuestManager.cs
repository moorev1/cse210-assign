using System;
using System.Collections.Generic;

public class QuestSystem
{
    private List<Goal> Goals;

    public QuestSystem()
    {
        Goals = new List<Goal>();
    }

    public void CreateNewGoal(string goalType, string name, int value, int targetCount = 0, int bonusValue = 0)
    {
        Goal goal;

        if (goalType.ToLower() == "simple")
        {
            goal = new SimpleGoal(name, value);
        }
        else if (goalType.ToLower() == "checklist")
        {
            goal = new ChecklistGoal(name, value, targetCount, bonusValue);
        }
        else
        {
            // Default to simple goal
            goal = new SimpleGoal(name, value);
        }

        Goals.Add(goal);
    }

    public void ListGoals()
    {
        foreach (var goal in Goals)
        {
            string status = goal.Completed ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{status} {goal.Name} - Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times");
            }
            else
            {
                Console.WriteLine($"{status} {goal.Name}");
            }
        }
    }

    public void SaveGoals()
    {
        // Implement saving logic here
    }

    public void LoadGoals()
    {
        // Implement loading logic here
    }

    public int RecordGoal(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.Name == goalName && !goal.Completed)
            {
                int pointsEarned = goal.RecordProgress();
                Console.WriteLine($"Goal '{goalName}' completed! You earned {pointsEarned} points.");
                return pointsEarned;
            }
        }

        Console.WriteLine($"Goal '{goalName}' not found or already completed.");
        return 0;
    }
}
