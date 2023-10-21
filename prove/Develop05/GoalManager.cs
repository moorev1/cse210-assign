using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> goals;
    private int userScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        userScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.Complete();
            userScore += goal.GetValue();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayStatus();
        }
        Console.WriteLine($"Your Total Score: {userScore} points");
    }
}
