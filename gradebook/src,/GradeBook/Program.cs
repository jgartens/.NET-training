using System;
using System.Collections.Generic;

namespace GradeBook
{
  
    class Program
    {
        static void Main(string[] args)
        {
            double x = 14.1;
            var y = 47.9075;
            double z = x + y;
            Console.WriteLine(z);

            double [] numbers = new double[] {2,4,5,6};
            numbers[0] = 2;
            numbers[1] = 4.5;
            numbers[2] = numbers[0] + numbers[1];

            double result = 0;
            foreach(double number in numbers){
                result += number;
            }
            Console.WriteLine(result);


            List<double> grades = new List<double>();
            grades.Add(42.9);
            grades.Add(84.3);
            grades.Add(91.0);
            grades.Add(81.1);

            result = 0;
            foreach (double grade in grades){
                result += grade;
            }
            result /= grades.Count;


           
        }
    }
}
