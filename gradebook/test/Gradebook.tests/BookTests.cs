using System;
using Microsoft.CSharp.RuntimeBinder;
using Xunit;
using GradeBook;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            //arrange
            var book = new Book();
            book.AddGrade(65.1);
            book.AddGrade(75.9);
            book.AddGrade(95.6);

            var expected = 95.6;
            //act
            var result = book.getStatistics();

            //assert
            Assert.Equal(expected, result.high);
        }
    }
}
