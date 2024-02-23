namespace Exercise1;

public interface IScoreBoard
{
    public int GetIndexStudent(string id);
    public Boolean ReadFile(string subjectId, string semesterId);
    public void UpdateFile();
    public int AddScoreStudent();
    public Boolean EraseStudentScore(string studentId);
    public string GetStudentScore(string studentId);
    public StudentScore GetHighestScore();
    public StudentScore GetLowestScore();
    public string DisplayStar(int number);
    public void UpdateFileReport(string filePath);
    public void CreateFileData();
    public void DisplayScore();
    public void DisplayScoreReport(string filePath);
}