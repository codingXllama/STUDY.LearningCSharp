namespace Part2_GuidedProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise();
        }

        // Exercise from https://learn.microsoft.com/en-us/training/modules/guided-project-arrays-iteration-selection/2-prepare
        private static void Exercise()
        {
            const int currentAssignments = 5;
            var sophiaScores = new int[] { 90, 85, 87, 98, 100 };
            var andrewScores = new int[] { 92, 89, 81, 96, 90 };
            var emmaScores = new int[] { 90, 85, 87, 98, 68 };
            var loganScores = new int[] { 90, 95, 87, 88, 96 };

            const int sophiaSum = 0;
            const decimal sophiaScore = (decimal)sophiaSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            // displaying each grade in Sophia socres
            foreach (var score in sophiaScores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            var studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            //displaying list of students
            foreach (var name in studentNames)
            {
                Console.WriteLine($"Students name is: {name}");
            }
        }
    }
}
