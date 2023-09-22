using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public int Rating { get; set; }

    public JournalEntry(string prompt, string response, DateTime date, int rating)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Rating = rating;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nRating: {Rating}\n";
    }
}
