using System;

namespace Assignment_5_Student_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] preetScores = { 7, 6, 5, 4, 3 };
            Student Preet = new Student("Preet", 12, preetScores);

            Console.WriteLine(Preet.GetHighest());
        }
    }
}
