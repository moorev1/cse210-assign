public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity(int duration)
    {
        Console.WriteLine($"Welcome to {name} Activity - {description}");
        Console.WriteLine($"Duration: {duration} seconds");
        PrepareToBegin();
        Thread.Sleep(2000);  // Pause for 2 seconds before starting

        string[] breaths = { "Breathe in...", "Now Breathe out..." };

        for (int i = 0; i < duration; i++)
        {
            foreach (var breath in breaths)
            {
                Console.WriteLine(breath);

                // Countdown before the next breath
                Console.WriteLine($"Next breath in {duration - i} seconds.");
                Thread.Sleep(1000);
            }
        }

        // Display the standard finishing message
        FinishActivity(duration);
    }
}
