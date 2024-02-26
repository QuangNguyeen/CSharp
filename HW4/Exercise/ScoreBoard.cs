namespace Exercise1;

public class ScoreBoard : IScoreBoard
{
    private Subject? _subject;
    private List<StudentScore> _listStudentScores = new List<StudentScore>();
    private string? _semester;
    private int _currentStudent = 0; // number of student in file
    private int _quantityStudent;   // max student in a subject
    private string? _path ; // create a empty path for creating new file
    private double _maxScore; // max Score in listStudentScore;
    private double _minScore; // min Score in listStudentScore;
    private double _avgScore; // average Score in listStudentScore;
    private int _scoreA = 0; // count A score
    private int _scoreB = 0; // count B socre
    private int _scoreC = 0; // count C score
    private int _scoreD = 0; // count D score
    private int _scoreF = 0; // count F score

    //  Property 
    public Subject Course
    {
        get => _subject ?? throw new InvalidOperationException("Subject is not initialized.");
        set => _subject = value;
    }

    public string Semester
    {
        get => _semester ?? throw new InvalidOperationException("Semester is not initialized.");
        set => _semester = value;
    }

    public int QuantityStudent
    {
        get => _quantityStudent;
        set => _quantityStudent = value;
    }

    public int CurrentStudent
    {
        get => _currentStudent;
        set => _currentStudent = value;
    }

    public double MaxScore
    {
        get => _maxScore;
        set => _maxScore = value;
    }

    public double MinScore
    {
        get => _minScore;
        set => _minScore = value;
    }

    public double AvgScore
    {
        get => _avgScore;
        set => _avgScore = value;
    }

    public int ScoreA
    {
        get => _scoreA;
        set => _scoreA = value;
    }

    public int ScoreB
    {
        get => _scoreB;
        set => _scoreB = value;
    }

    public int ScoreC
    {
        get => _scoreC;
        set => _scoreC = value;
    }

    public int ScoreD
    {
        get => _scoreD;
        set => _scoreD = value;
    }

    public int ScoreF
    {
        get => _scoreF;
        set => _scoreF = value;
    }

    public string Path
    {
        get => _path ;
        set => _path = value;
    }

    // Constructor
    public ScoreBoard()
    {
    }

    /** Constructor create  a new Score Board
     * if File Score is exist, read information from this file
     * @param _subject
     * @param _semester
     * @param _quantityStudent
     */
    public ScoreBoard(Subject subject, string semester, int quantityStudent)
    {
        // set property
        Course = subject;
        Semester = semester;
        Path = $"/Users/macbook/Documents/C#/HW4/Exercise/DataScore/{Course.IdSubject}_{Semester}.txt";
        try
        {
            if (!File.Exists(Path))
            {
                using (var newFile = new FileStream(Path, FileMode.CreateNew)) ;
                Console.WriteLine("File was created!");
                QuantityStudent = quantityStudent;
                UpdateFile(); 
            }
            else
            {
                Console.WriteLine("File already exist.");
                ReadFile(Course.IdSubject, Semester);
            }
            
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"IO Error: {ex.Message}");
        }
    }

    public Boolean ReadFile(string subjectId, string semester)
    {
        try
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                string? line = reader.ReadLine();
                if (line == null)
                {
                    return false; // file is empty
                }

                // Subject ID
                string[] subjectInfor = line.Split('|');
                Course.IdSubject = subjectInfor[1].Trim();
                // Subject Name
                line = reader.ReadLine();
                if (line != null)
                {
                    string[] subjectData = line.Split('|');
                    Course.SubjectName = subjectData[1].Trim();
                }
                // Coefficient Point or Rate Point
                line = reader.ReadLine();
                if (line != null)
                {
                    string[] coefficientData = line.Split('|');
                    Course.ProcessCoefficient = Convert.ToDouble(coefficientData[1]);
                    Course.ExamCoefficient = Convert.ToDouble(coefficientData[2]);
                }
                // Semester
                line = reader.ReadLine();
                if (line != null)
                {
                    string[] semesterData = line.Split('|');
                    Semester = semesterData[1].Trim();
                }
                // Quantity Student
                line = reader.ReadLine();
                if (line != null)
                {
                    string[] quantityData = line.Split('|');
                    QuantityStudent = Convert.ToInt32(quantityData[1]);
                }

                // Student Score
                while ((line = reader.ReadLine()) != null)
                {
                    // Read until the end of file
                    string[] studentScoreData = line.Split('|');
                    string id = studentScoreData[1].Trim();
                    string surAndMiddleName = studentScoreData[2].Trim();
                    string name = studentScoreData[3].Trim();
                    double processScore = Convert.ToDouble(studentScoreData[4]);
                    double finalScore = Convert.ToDouble(studentScoreData[5]);
                    StudentScore studentScore = new StudentScore();
                    studentScore.Id = id;
                    studentScore.SurAndMiddleName = surAndMiddleName;
                    studentScore.Name = name;
                    studentScore.ProcessScore = processScore;
                    studentScore.ExamFinalScore = finalScore;
                    _listStudentScores.Add(studentScore);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        return true;
    }

    // Update File Score
    public void UpdateFile()
    {
        CurrentStudent = _listStudentScores.Count;  // count again number student in list
        try
        {
            using (FileStream stream = new FileStream(Path, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"SubjectID|{Course.IdSubject}");
                writer.WriteLine($"Subject|{Course.SubjectName}");
                writer.WriteLine($"F|{Course.ProcessCoefficient}|{Course.ExamCoefficient}");
                writer.WriteLine($"StudentCount|{QuantityStudent}");
                foreach (var score in _listStudentScores)
                {
                    writer.WriteLine(score.GetMarkLine(Course.ProcessCoefficient));
                }

                writer.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Add Student Score Information
    public int AddScoreStudent()
    {
        Console.WriteLine("Enter Student ID: ");
        string? id = Console.ReadLine();
        if (id != null)
        {
            int index = GetIndexStudent(id);
            if (index >= 0)
            {
                // if have student in list Student Score
                Console.WriteLine("This student is existed on list.");
                Console.WriteLine("Do you want change student data ? ");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 2) return 0; // Nothing  to do
                if (choice == 1)
                {
                    Console.WriteLine("Enter Process Score: ");
                    double processScore = Convert.ToDouble(Console.ReadLine());
                    if (processScore <= 0)
                    {
                        Console.WriteLine("Process is invalid. ");
                        return 0;
                    }

                    Console.WriteLine("Enter Final Score: ");
                    double finalScore = Convert.ToDouble(Console.ReadLine());
                    if (finalScore <= 0)
                    {
                        Console.WriteLine("Final Score is invalid. ");
                        return 0;
                    }
                }
            }
            else
            {
                // if student not on list
                Console.WriteLine("This list not have this ID, append new Student.");
                Console.WriteLine("Enter New Student ID: ");
                string? newid = Console.ReadLine();
                Console.WriteLine("Enter Surname And Middle Name: ");
                string? newsurAndMiddleName = Console.ReadLine();
                Console.WriteLine("Enter Student Name: ");
                string? newName = Console.ReadLine();
                Console.WriteLine("Enter Process Score: ");
                double processScore = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Final Score: ");
                double finalScore = Convert.ToDouble(Console.ReadLine());
                StudentScore newScore = new StudentScore();
                newScore.Id = newid ?? "defaultID";
                newScore.SurAndMiddleName = newsurAndMiddleName ?? "defaultName";
                newScore.Name = newName ?? "defaultName";
                newScore.ProcessScore = processScore;
                newScore.ExamFinalScore = finalScore;
                _listStudentScores.Add(newScore);
            }
        }

        Console.WriteLine("Do you want to continue add new Student Score with this Subject.");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 1) AddScoreStudent();
        return 1;
    }

    // Get Student in ListStudentScores
    public int GetIndexStudent(string id)
    {
        for (int i = 0; i < _listStudentScores.Count; i++)
        {
            if (id.Equals(_listStudentScores[i].Id))
            {
                return i;
            }
        }

        return -1;
    }

    public Boolean EraseStudentScore(string studentId)
    {
        int index = GetIndexStudent(studentId);
        if (index < 0)
        {
            return false;
        }

        _listStudentScores.RemoveAt(index);
        return true;
    }

    public string GetStudentScore(string studentId)
    {
        int index = GetIndexStudent(studentId);
        if (index < 0)
        {
            Console.WriteLine("Sorry. This Student is not on List.");
        }
        else
        {
            return _listStudentScores.ElementAt(index).GetMarkLine(_listStudentScores.ElementAt(index).ProcessScore);
        }

        return string.Empty;
    }

    public StudentScore GetHighestScore()
    {
        _maxScore = 0;
        _minScore = 10;
        _avgScore = 0;
        if (_listStudentScores.Count > 0)
        {
            foreach (var studentScore in _listStudentScores)
            {
                double score = studentScore.GetOverallScore(Course.ProcessCoefficient);
                if (MaxScore < score)
                {
                    MaxScore = score;
                }

                if (_minScore > score)
                {
                    _minScore = score;
                }

                _avgScore += score;
                if (score < 4.0) _scoreF++;
                else if (score < 5.5) _scoreD++;
                else if (score < 7.0) _scoreC++;
                else if (score < 8.5) _scoreB++;
                else _scoreA++;
            }

            _avgScore /= _listStudentScores.Count;
            foreach (var score in _listStudentScores)
            {
                if (score.GetOverallScore(Course.ProcessCoefficient) == MaxScore)
                {
                    return score;
                }
            }
        }
        else
        {
            Console.WriteLine("The Database not hava information about any students.");
            return null;
        }

        return null;
    }

    public StudentScore GetLowestScore()
    {
        if (_listStudentScores.Count > 0)
        {
            foreach (var score in _listStudentScores)
            {
                if (_minScore == score.GetOverallScore(Course.ProcessCoefficient))
                {
                    return score;
                }
            }
        }
        else
        {
            Console.WriteLine("The Database not hava information about any students.");
            return null;
        }

        return null;
    }

    public string DisplayStar(int number)
    {
        string S = "";
        for (int i = 0; i < number; i++)
        {
            S += "*";
        }

        return S;
    }

    public void UpdateFileReport(string filePath)
    {
        try
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{Course.IdSubject}_{Semester}_rp.txt");
                StudentScore studentH = GetHighestScore();
                StudentScore studentL = GetLowestScore();
                writer.WriteLine($"The student with the highest mark is: {studentH.SurAndMiddleName} {studentH.Name}");
                writer.WriteLine($"The student with the lowest mark is: {studentL.SurAndMiddleName} {studentL.Name}");
                writer.WriteLine($"The average mark is: {AvgScore}");
                writer.WriteLine();
                writer.WriteLine($"A histogram of the subject {Course.IdSubject} is:");
                writer.WriteLine($"A:{DisplayStar(ScoreA)}");
                writer.WriteLine($"B:{DisplayStar(ScoreB)}");
                writer.WriteLine($"C:{DisplayStar(ScoreC)}");
                writer.WriteLine($"D:{DisplayStar(ScoreD)}");
                writer.WriteLine($"F:{DisplayStar(ScoreF)}");
                writer.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    /// <summary>
    ///  Create file report, if File is Exist, Update File
    /// </summary>
    public void CreateFileData()
    {
        string pathReport = $"/Users/macbook/Documents/C#/HW4/Exercise/DataScore/{Course.IdSubject}_{Semester}_rp.txt";
        try
        {
            FileInfo fileReport = new FileInfo(pathReport);
            if (!fileReport.Exists)
            {
                Console.WriteLine("File Report is exist. Updating information.....");
                UpdateFileReport(pathReport);
                DisplayScoreReport(pathReport);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void DisplayScore()
    {
        try
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine();
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void DisplayScoreReport(string filePath)
    {
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}