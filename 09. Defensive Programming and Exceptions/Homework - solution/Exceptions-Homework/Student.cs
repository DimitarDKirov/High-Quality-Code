﻿using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null)
        {
            throw new ArgumentNullException("Invalid first name!");
        }

        if (lastName == null)
        {
            throw new ArgumentNullException("Invalid last name!");
        }

        if (exams == null)
        {
            throw new ArgumentNullException("Exams must be provided");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
            return null;
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
     
        if (this.Exams.Count == 0)
        {
            // No exams --> return -1;
            return -1;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
