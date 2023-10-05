// WritingAssignment.cs

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
        string studentName = GetStudentName();
        string assignmentName = GetAssignmentName();

        Console.WriteLine($"{studentName} - {assignmentName}");
        Console.WriteLine($"The Causes of {_topic} by {studentName}");
    }
}
