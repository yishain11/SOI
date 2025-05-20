using System;

// bad - too many diff things inside the same class - tightly cuppoled.
public class ReportManager
{
    public string ReportTitle { get; set; }
    public string ReportContent { get; set; }

    public void SaveToFile(string filePath)
    {
        File.WriteAllText(filePath, $"{ReportTitle}\n{ReportContent}");
    }

    public void SendEmail(string email)
    {
        Console.WriteLine($"Sending report to {email}...");
        // logic to send email
    }

    public void PrintReport()
    {
        Console.WriteLine($"Printing: {ReportTitle}\n{ReportContent}");
    }
}

// fix - break down
public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }
}

public class ReportSaver
{
    public void SaveToFile(Report report, string filePath)
    {
        File.WriteAllText(filePath, $"{report.Title}\n{report.Content}");
    }
}

public class ReportEmailer
{
    public void SendEmail(Report report, string email)
    {
        Console.WriteLine($"Sending report '{report.Title}' to {email}...");
        // email logic
    }
}

public class ReportPrinter
{
    public void Print(Report report)
    {
        Console.WriteLine($"Printing: {report.Title}\n{report.Content}");
    }
}