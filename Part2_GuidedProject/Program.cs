namespace Part2_GuidedProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise();
        }

        // Exercise from https://learn.microsoft.com/en-us/training/modules/guided-project-arrays-iteration-selection/2-prepare
        public static void Exercise()
        {
            int currentAssignments = 5;
            int[] sophiaScores = new int[] { 90, 85, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            int sophiaSum = 0;
            decimal sophiaScore;
            sophiaScore = (decimal)sophiaSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            // displaying each grade in Sophia socres
            foreach (int score in sophiaScores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            //displaying list of students
            foreach (string student in studentNames)
            {
                Console.WriteLine(student);
            }
        }
    }
}
