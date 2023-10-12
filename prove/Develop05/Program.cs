using System;

class Program
{
    static void Main()
    {
        QuestSystem questSystem = new QuestSystem();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple goal");
                    Console.WriteLine("2. Eternal goal");
                    Console.WriteLine("3. Checklist Goal");

                    Console.Write("What type of goal would you like to create? ");
                    string goalTypeChoice = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal value: ");
                    int value = int.Parse(Console.ReadLine());

                    if (goalTypeChoice == "1")
                    {
                        questSystem.CreateNewGoal("simple", name, value);
                    }
                    else if (goalTypeChoice == "2")
                    {
                        questSystem.CreateNewGoal("eternal", name, value);
                    }
                    else if (goalTypeChoice == "3")
                    {
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus value: ");
                        int bonusValue = int.Parse(Console.ReadLine());
                        questSystem.CreateNewGoal("checklist", name, value, targetCount, bonusValue);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type choice. Please try again.");
                    }
                    break;

                case "2":
                    questSystem.ListGoals();
                    break;

                case "3":
                    questSystem.SaveGoals();
                    break;

                case "4":
                    questSystem.LoadGoals();
                    break;

                case "5":
                    Console.Write("Enter the name of the goal to record: ");
                    string goalName = Console.ReadLine();
                    questSystem.RecordGoal(goalName);
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
