using System.Xml.Linq;

namespace Part2_GuidedProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise();
            //HardCodedApproach();
            //ArrayApproach();
            //NestedApproachForOneStudent();
        }

        // Exercise from https://learn.microsoft.com/en-us/training/modules/guided-project-arrays-iteration-selection/2-prepare
        private static void Exercise()
        {
            const int currentAssignments = 5;
            var sophiaScores = new int[] { 90, 85, 87, 98, 100 };
            var andrewScores = new int[] { 92, 89, 81, 96, 90 };
            var emmaScores = new int[] { 90, 85, 87, 98, 68 };
            var loganScores = new int[] { 90, 95, 87, 88, 96 };




            var sophiaSum = 0;
            var sophiaScore = (decimal)sophiaSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            // displaying each grade in Sophia socres
            foreach (var score in sophiaScores)
            {
                Console.WriteLine(score);

                sophiaSum += score;
            }

            Console.WriteLine($"Sophia's score is {sophiaSum}");

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

            var studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            //displaying list of students
            foreach (var name in studentNames)
            {
                Console.WriteLine($"Students name is: {name}");
            }
        }

        private static void HardCodedApproach()
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 90;
            int sophia2 = 86;
            int sophia3 = 87;
            int sophia4 = 98;
            int sophia5 = 100;

            int andrew1 = 92;
            int andrew2 = 89;
            int andrew3 = 81;
            int andrew4 = 96;
            int andrew5 = 90;

            int emma1 = 90;
            int emma2 = 85;
            int emma3 = 87;
            int emma4 = 98;
            int emma5 = 68;

            int logan1 = 90;
            int logan2 = 95;
            int logan3 = 87;
            int logan4 = 88;
            int logan5 = 96;

            int sophiaSum = 0;
            int andrewSum = 0;
            int emmaSum = 0;
            int loganSum = 0;

            decimal sophiaScore;
            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;

            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

            sophiaScore = (decimal)sophiaSum / currentAssignments;
            andrewScore = (decimal)andrewSum / currentAssignments;
            emmaScore = (decimal)emmaSum / currentAssignments;
            loganScore = (decimal)loganSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }

        private static void ArrayApproach()
        {
            int currentAssignments = 5;
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            int sophiaSum = 0;
            int andrewSum = 0;
            int emmaSum = 0;
            int loganSum = 0;


            decimal sophiaScore;
            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;


            // calculating Sophia's grade 
            foreach (var score in sophiaScores)
            {
                sophiaSum += score;
            }

            sophiaScore = (decimal)sophiaSum / currentAssignments;


            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();




        }

        private static void NestedApproachForOneStudent()
        {
            const int currentAssignments = 5;
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
            int[] studentScores = new int[10];

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };




            decimal sophiaScore,andrewScore, emmaScore, loganScore;


            foreach (string name in studentNames)
            {
                //Console.WriteLine($"{name}");

                if (name.Contains("Sophia"))
                {
                    int sophiaSum = 0;

                    //Console.WriteLine("This is Sophia");
                    foreach (int grade in sophiaScores )
                    {
                        sophiaSum+= grade;
                    }
                    sophiaScore = (decimal)sophiaSum / currentAssignments;
                    Console.WriteLine("\nStudent\t\tGrade\n");
                    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
                }
                
            }



            Console.WriteLine("Press the Enter key to continue ");
            Console.ReadLine();



        }

        

    }


}




