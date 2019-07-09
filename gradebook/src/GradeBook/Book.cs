using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book       // can use internal as well if you dont want to expose it for referencing.
    {
        public Book(string name)   //Constructor method, normally used for initialization
        {
            grades = new List<double>();
            this.name = name;       //this keyword is used to tell implicitly to use the member variable of this class.
        }
        public void AddGrade(double grade)      //instance method or instance member of class book
        {
            grades.Add(grade);  //Storing the incoming grade into the grades list
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade,result.Low);
                result.Average += grade;
            }
            result.Average /= (grades.Count);

            return result; 
        }

        private List<double> grades;        //No longer a variable, its a FIELD as used outside method. So in field you cant use var varible.
        private string name;
    }
}