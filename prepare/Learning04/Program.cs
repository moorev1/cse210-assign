using System;

class Program
{
    static void Main()
    {
        // Testing the base Assignment class
        Assignment mathAssignment = new Assignment("Vincent Moore", "Multiplication");
        string mathSummary = mathAssignment.GetSummary();

        Console.WriteLine("Math Assignment Summary:");
        Console.WriteLine(mathSummary);
        Console.WriteLine();

        // Testing the MathAssignment class
        MathAssignment mathHomework = new MathAssignment("Moore Vincent", "Fractions", "Section 7.3", "Problems 8-19");
        string mathHomeworkSummary = mathHomework.GetSummary();
        string mathHomeworkList = mathHomework.GetHomeworkList();

        Console.WriteLine("Math Homework Summary:");
        Console.WriteLine(mathHomeworkSummary);
        Console.WriteLine("Math Homework List:");
        Console.WriteLine(mathHomeworkList);
        Console.WriteLine();

        // Testing the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Vincent Moore", "European History", "World War II");
        writingAssignment.GetWritingInformation();
    }
}