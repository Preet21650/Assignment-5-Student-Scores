using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Student_Scores
{
    class Student
    {
        private string name;
        private int year;
        // scores -----------> object of 5 spaces
        private int[] scores = new int[5];

        public Student(string name, int year,int[] scores)
        {
            this.name = name;
            this.year = year;
            //scores ----------> other object containing a number of elements
            this.scores = scores;
        }
        public double GetAverage()
        {
            int total = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                total = total + scores[i];
            }
            double average =(double) total / scores.Length;
            return average;
        }
        public int GetHighest()
        {
            int highest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > highest) highest = scores[i];
            }
                return highest;
            
        }
        public int GetLowest()
        {
            int lowest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < lowest) lowest = scores[i];
            }
            return lowest;

        }
        public int[] GetScores()
        {
            return scores;
        }
    }
}
