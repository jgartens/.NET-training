﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
  
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(80);
            book.AddGrade(91);

            book.showStatistics();
           
        }
    }
}
