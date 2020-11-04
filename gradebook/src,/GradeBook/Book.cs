using System.Collections.Generic;
using System;

namespace GradeBook{

    class Book{

        public List<double> grades;
        private List<string> names;


        public void AddGrade(double grade){
            this.grades.Add(grade);
            return;
        }

        public void changeName(List<string> names){
            this.names = names;
        }

        public Book(){
            this.grades = new List<double>();
        }

        public void showStatistics(){
            double max = 0;
            double min = double.MaxValue;

            foreach(var number in grades){
                max = Math.Max(number, max);
                min = Math.Min(number, min);
            }

            Console.Write($"The highest grade is: {max}\n");
            Console.Write($"The lowest grade is: {min}\n");
            
        }

    }
}