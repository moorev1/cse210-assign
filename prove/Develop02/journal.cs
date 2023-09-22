using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response, int rating)
    {
        JournalEntry entry = new JournalEntry(prompt, response, DateTime.Now, rating);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToCsv(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Date,Prompt,Response,Rating");
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response},{entry.Rating}");
            }
        }
    }

    public void LoadFromCsv(string fileName)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            bool isFirstLine = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    continue;
                }

                var values = line.Split(',');
                if (values.Length == 4)
                {
                    DateTime date = DateTime.Parse(values[0]);
                    string prompt = values[1];
                    string response = values[2];
                    int rating = int.Parse(values[3]);
                    AddEntry(prompt, response, rating);
                }
            }
        }
    }

    public double CalculateAverageRating()
    {
        if (entries.Count == 0)
        {
            return 0.0;
        }
        return entries.Average(entry => entry.Rating);
    }
}
