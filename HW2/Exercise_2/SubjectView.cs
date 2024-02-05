
using System.Diagnostics;

namespace Exercise_2;

public class SubjectView
{
    public void DisplaySubjectInfor(SubjectModel subject)
    {
        Console.WriteLine($"Subject ID: {subject.SubjectId}");
        Console.WriteLine($"Subject Name: {subject.SubjectName}");
        Console.WriteLine($"Quota: {subject.Quota}");
        Console.WriteLine($"Currently Enrol: {subject.CurrentEnrolment}");
        int availablePlaces = subject.Quota - subject.CurrentEnrolment;
        Console.WriteLine($"Can add: {availablePlaces} to Subject. ");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Subject Management System");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("1. Append new subject");
        Console.WriteLine("2. Update subject");
        Console.WriteLine("3. Display the information of subject");
        Console.WriteLine("4. Add new student to subject");
        Console.WriteLine("5. Remove student from subject");
        Console.WriteLine("Your choice (1-4, other to quit): ");
    }
    
}