using System.Collections.Generic;

namespace GradeBook{

    class Book{

        List<double> grades;


        public void AddGrade(double grade){
            this.grades.Add(grade);
            return;
        }

        public Book(){
            this.grades = new List<double>();
        }

    }
}