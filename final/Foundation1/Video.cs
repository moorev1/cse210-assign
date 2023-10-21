// Video.cs
using System;
using System.Collections.Generic;

// Video class definition
class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");

        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- Comment by {comment.Commenter}: {comment.Text}");
        }

        Console.WriteLine();
    }
}
