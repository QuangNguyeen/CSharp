namespace Exercise4
{
    public class EnrolmentManagement
    {
        private enum Option
        {
            AddNormalSubject = 1,
            AddSpecialSubject = 2,
            RemoveSubject = 3,
            DisplayFeeInformation = 4
        }
        public static List<dynamic> ListSubject = new List<dynamic>();

        public static void DisplayMenu()
        {
            Console.WriteLine("Enrolment Management System");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Add a normal subject");
            Console.WriteLine("2. Add a special subject");
            Console.WriteLine("3. Remove a subject");
            Console.WriteLine("4. Display fee information");
            Console.WriteLine("Your choice (1-3, other to quit):");
        }
        
        public static void AddNormalSubject(List<dynamic> ListSubject)
        {
            Subject newSubject = new Subject(); // Make sure you have Subject class
            newSubject.Input();
            ListSubject.Add(newSubject);
        }

        public static void AddSpecialSubject(List<dynamic> ListSubject)
        {
            SpecialSubject newSubject = new SpecialSubject();
            newSubject.Input();
            ListSubject.Add(newSubject);
        }
        public static void DisplayFeeInformation(List<dynamic> ListSubject)
        {
            double sumNormalFee = 0;
            double sumSpecialFee = 0;
            Console.WriteLine("FEE INFORMATION");
            Console.WriteLine("*****");
            Console.WriteLine("Normal Subjects");
            foreach (var subject in ListSubject)
            {
                if (subject.GetType() == typeof(Subject))
                {
                    Console.WriteLine(subject.GetEnrolmentLine()); // Print the enrollment line
                    sumNormalFee += subject.Tuition;
                }
            }
            Console.WriteLine("-----");
            Console.WriteLine($"Total: {sumNormalFee}");
            Console.WriteLine("Special Subjects");
            foreach (var subject in ListSubject)
            {
                if (subject.GetType() == typeof(SpecialSubject))
                {
                    Console.WriteLine(subject.GetEnrolmentLine()); // Print the enrollment line
                    sumSpecialFee += subject.Tuition;
                }
            }
            Console.WriteLine("-----");
            Console.WriteLine($"Total: {sumSpecialFee}");
        }

        public static void RemoveSubject(List<dynamic> ListSubject)
        {
            Console.WriteLine("Enter ID Subject to Remove: ");
            string id = Console.ReadLine();
            bool checkExist = false;
            int quantity = ListSubject.Count;
            for (int i = 0; i < quantity; i++)
            {
                if (id.Equals(ListSubject[i].Id))
                {
                    checkExist = true;
                    ListSubject.RemoveAt(i);
                    break;
                }
            }
            if (checkExist == false)
            {
                Console.WriteLine("Not Found Subject. ");
            }
        }

        public static void Main(string[] args)
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch ((Option)choice)
                {
                    case Option.AddNormalSubject:
                        {
                            AddNormalSubject(ListSubject);
                            break;
                        }
                    case Option.AddSpecialSubject:
                        {
                            AddSpecialSubject(ListSubject);
                            break;
                        }
                    case Option.RemoveSubject:
                        {
                            RemoveSubject(ListSubject);
                            break;
                        }
                    case Option.DisplayFeeInformation:
                        {
                            DisplayFeeInformation(ListSubject);
                            break;
                        }
                }
            } while (true);
        }
    }
}
