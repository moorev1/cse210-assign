using System;

class ReflectionActivity : ReflectionListingActivity
{
    public ReflectionActivity()
    {
        name = "Reflection";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        prompts = new[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        questions = new[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?"
        };
    }

     protected override void PerformActivity(int duration)
    {
        ShowPrompt();

        Console.WriteLine("Take a moment to think about the prompt. Press Enter when ready.");
        Console.ReadLine();

        Console.WriteLine("Get ready to start listing items:");
        Thread.Sleep(3000); // Countdown pause before starting

        int itemCounter = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            string item = Console.ReadLine();

            if (item.ToLower() == "done")
                break;

            itemCounter++;
        }

        Console.WriteLine($"\nNumber of items entered: {itemCounter}");
    }

        // Display the standard finishing message
      //  FinishActivity(duration);
    }
//}

class ListingActivity : ReflectionListingActivity
{
    public ListingActivity()
    {
        name = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        prompts = new[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

     protected override void PerformActivity(int duration)
    {
        ShowPrompt();

        Console.WriteLine("Take a moment to think about the prompt. Press Enter when ready.");
        Console.ReadLine();

        Console.WriteLine("Get ready to start listing items:");
        Thread.Sleep(3000); // Countdown pause before starting

        int itemCounter = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            string item = Console.ReadLine();

            if (item.ToLower() == "done")
                break;

            itemCounter++;
        }

        Console.WriteLine($"\nNumber of items entered: {itemCounter}");
    }
}

// ... (unchanged code)

class Program
{
    static void Main()
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        MindfulnessActivity[] activities = { breathing, reflection, listing ,};

        while (true)
        {
           Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
           if (choice == "4")
{
    Console.WriteLine("You have gracefully quit the program. Goodbye!");
    break;
}

            if (int.TryParse(choice, out int activityIndex) && activityIndex >= 1 && activityIndex <= activities.Length)
            {
                MindfulnessActivity selectedActivity = activities[activityIndex - 1];
                Console.Write($"Welcome to Breathing Activity.\n");
                // Prompt for the duration
                Console.Write($"How long, in seconds, would you like for your session?");
                int duration = int.Parse(Console.ReadLine());
                selectedActivity.Start(duration);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }
        }
    }
}