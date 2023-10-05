using System;

public class WritingAssignment : Assignment
{
    private string _topic;

    public WritingAssignment(string studentName, string assignmentName, string topic)
        : base(studentName, assignmentName)
    {
        _topic = topic;
    }

    public void GetWritingInformation()
    {
        string studentName = GetSummary();
        Console.WriteLine($"{studentName}");
        Console.WriteLine($"The Causes of {_topic} by {studentName}");
    }
}