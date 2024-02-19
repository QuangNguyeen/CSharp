namespace Exercise1;

public class ScoreManagement
{
    public static void Main(string[] args)
    {
        int choice;
        do
        {
            DisplayMenu();
            choice = Convert.ToInt32(Console.ReadLine());
            switch ((Option)choice)
            {
                case Option.AddNewScoreBoard:
                {
                    AddNewScoreBoard();
                    break;
                }
                case Option.AddScore:
                {
                    AddScore();
                    break;
                }
                case Option.RemoveScore:
                {
                    break;
                }
                case Option.SearchScore:
                {
                    break;
                }
                case Option.DisplayScore:
                {
                    break;
                }
            }
        } while (choice >= 1 && choice <= 5);
    }
}
