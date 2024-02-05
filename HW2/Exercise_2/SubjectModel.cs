namespace Exercise_2;

public class SubjectModel
{
    public string SubjectId { get; set; }
    public string SubjectName { get; set; }
    public int Quota { get; set; }
    public int CurrentEnrolment { get; set; }

    public List<string> ListStudent;
    // Constructor
    public SubjectModel()
    {
        SubjectId = "000";
        SubjectName = "Subject";
        ListStudent = new List<string>();
        Quota = 0;
    }
    
    public void AddStudent()
    {
        Console.WriteLine("Add Student to Subject");
        if (CurrentEnrolment < Quota)
        {
            ++CurrentEnrolment;
            Console.WriteLine("Added 1 student to the course " + SubjectName);
        }
        else
        {
            Console.WriteLine($"The course {SubjectName} is full. Registration failed. ");
        }
    }

    public void RemoveStudent()
    {
        if (CurrentEnrolment <= 0)
        {
            Console.WriteLine("No student to remove. ");
        }
        else
        {
            --CurrentEnrolment;
            Console.WriteLine($"Removed 1 student from the course {SubjectName}");
        }
    }
    
}