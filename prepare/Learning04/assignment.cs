// Assignment.cs

using System;

public class Assignment
{
    protected string _studentName;
    private string _assignmentName;

    public Assignment(string studentName, string assignmentName)
    {
        _studentName = studentName;
        _assignmentName = assignmentName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetAssignmentName()
    {
        return _assignmentName;
    }
}
