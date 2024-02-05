using System;
namespace Exercise_2;

public class SubjectController
{
    public List<SubjectModel> ListSubject;
    public SubjectView View;

    // Constructor
    public SubjectController()
    {
        ListSubject = new List<SubjectModel>();
        View = new SubjectView();
    }
    public void AppendNewSubject()
    {
        SubjectModel newSubject = new SubjectModel();

        Console.WriteLine("Enter New Subject ID: ");
        string? NewID = Console.ReadLine();
        Console.WriteLine("Enter New Subject Name: ");
        string? NewName = Console.ReadLine();

        Console.WriteLine("Enter New Subject Quota: ");
        int NewQuota = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter New Currently Enrolment: ");
        int NewEnrolment = Convert.ToInt32(Console.ReadLine());

        newSubject.SubjectId = NewID;
        newSubject.SubjectName = NewName;
        newSubject.Quota = NewQuota;
        newSubject.CurrentEnrolment = NewEnrolment;
        // Check if the subjectID already exists
        bool checkExist = ListSubject.Any(subject => subject.SubjectId.Equals(newSubject.SubjectId));

        if (checkExist)
        {
            Console.WriteLine("Subject already exists.");
        }
        else
        {
            ListSubject.Add(newSubject);
            Console.WriteLine("Subject added successfully.");
        }
    }
    
    public void UpdateSubject()
    {
        Console.WriteLine("Enter Subject ID to Update: ");
        string? id = Console.ReadLine();
        foreach (var subject in ListSubject)
        {
            if (subject.SubjectId.Equals(id))
            {
                Console.WriteLine("Enter New Subject ID: ");
                string? idUpdate = Console.ReadLine();
                Console.WriteLine("Enter New Subject Name: ");
                string? NameUpdate = Console.ReadLine();
                Console.WriteLine("Enter New Quota: ");
                var quotaUpdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Current Enrolment: ");
                var enrolmentUpdate = Convert.ToInt32(Console.ReadLine());
                subject.SubjectId = idUpdate;
                subject.SubjectName = NameUpdate;
                subject.Quota = quotaUpdate;
                subject.CurrentEnrolment = enrolmentUpdate;
            }
        }
    }

    public void DisplayInfor()
    {
        Console.WriteLine("Enter ID Subject To Display Information: ");
        string? id = Console.ReadLine();
        bool checkExist = false;
        foreach (var subject in ListSubject)
        {
            if (subject.SubjectId.Equals(id))
            {
                checkExist = true;
                View.DisplaySubjectInfor(subject);
                break;
            }
        }

        if (checkExist == false)
        {
            Console.WriteLine("Subject is not exist");
        }
    }

    public void AddStudentToSubject()
    {
        bool checkExist = false;
        Console.WriteLine("Enter ID Subject To Add Student: ");
        string? subjectID = Console.ReadLine();
        foreach (var subject in ListSubject)
        {
            if (subject.SubjectId.Equals(subjectID))
            {
                Console.WriteLine("Enter name student do add: ");
                string? newStudent = Console.ReadLine();
                bool checkStudent = false;
                foreach (var name in subject.ListStudent)
                {
                    if (name.Equals(newStudent))
                    {
                        checkExist = true;
                        Console.WriteLine("Student is Exist.");
                        break;
                    }
                }

                if (!checkExist && newStudent != null)
                {
                    subject.ListStudent.Add(newStudent);
                    Console.WriteLine("Added Successfully");
                }
            }
        }
    }
    public void ProcessChoice()
    {
        Console.WriteLine("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                AppendNewSubject();
                break;
            }
            case 2:
            {
                UpdateSubject();
                break;
            }
            case 3:
            {
                DisplayInfor();
                break;
            }
            case 4:
            {
                AddStudentToSubject();
                break;
            }
            default:
            {
                break;
            }
        }
    }
}