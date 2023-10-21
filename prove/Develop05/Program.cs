using System;
using System.Collections.Generic;

public class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                // Add cases for other options
            }

        } while (choice != 6);
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("What type of goal would you like to create? ");
        int goalType = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times should this goal be accomplished? ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount));
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].Display();
        }
    }

    // Add methods for other menu options
}
