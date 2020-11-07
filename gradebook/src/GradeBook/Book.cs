using System.Collections.Generic;
using System;


namespace GradeBook{

    public class Book{

        public List<double> grades;
        public String Name;


        public void AddGrade(double grade){
            this.grades.Add(grade);
            return;
        }

        public void changeName(String name){
            this.Name = name;
        }

        public Book(){
            this.grades = new List<double>();
        }

        public double showStatistics(){
            double max = 0;
            double min = double.MaxValue;

            foreach(var number in grades){
                max = Math.Max(number, max);
                min = Math.Min(number, min);
            }

            Console.Write($"The highest grade is: {max}\n");
            Console.Write($"The lowest grade is: {min}\n");
            
            return max;

    }
    public Stats getStatistics(){
            double max = 0;
            double min = double.MaxValue;

            foreach(var number in grades){
                max = Math.Max(number, max);
                min = Math.Min(number, min);
            }

            Stats result = new Stats(max, min);
            
            return result;

    }
}

}