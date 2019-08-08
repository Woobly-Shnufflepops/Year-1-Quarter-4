﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersFinal
{
    //Question 8
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
        public int GetAverageGrade()
        {
            double sum = 0;
            foreach (int grade in Scores)
                sum += grade;
            double avg = sum / Scores.Count;
            return (int)Math.Round(avg);
        }
    }

}

