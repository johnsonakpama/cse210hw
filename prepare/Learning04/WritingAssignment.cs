using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public GetWritingInformation()
    {
        string studentName = GetStudentName();
        
        return $"{title} by {studentName}";
    }
} 