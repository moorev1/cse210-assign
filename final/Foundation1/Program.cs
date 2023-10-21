// Program.cs
using System;
using System.Collections.Generic;

// Program class with the Main method
class Program
{
    static void Main()
    {
        // Create Video List
        List<Video> videos = new List<Video>();

        // Get user input for videos and comments
        Console.Write("Enter the number of videos: ");
        int numberOfVideos = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfVideos; i++)
        {
            Console.WriteLine($"\nVideo {i + 1}:");

            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author: ");
            string author = Console.ReadLine();

            Console.Write("Enter length (seconds): ");
            int length = int.Parse(Console.ReadLine());

            Video video = new Video(title, author, length);

            // Get user input for comments
            Console.Write("Enter the number of comments for this video: ");
            int numberOfComments = int.Parse(Console.ReadLine());
            for (int j = 0; j < numberOfComments; j++)
            {
                Console.WriteLine($"\nComment {j + 1}:");

                Console.Write("Enter commenter: ");
                string commenter = Console.ReadLine();

                Console.Write("Enter comment text: ");
                string text = Console.ReadLine();

                video.AddComment(new Comment(commenter, text));
            }

            videos.Add(video);
        }

        // Display Video Information
        Console.WriteLine("\nDisplaying Video Information:\n");
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
