using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string MathAssignment(string studentName, string topic, string textbookSection, string probiem):base(studentName, topib)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} problems {_problems}" ;
    }
}