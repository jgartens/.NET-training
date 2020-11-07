using System;
using Microsoft.CSharp.RuntimeBinder;
using Xunit;
using GradeBook;

namespace GradeBook.tests
{
    public class TypeTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            var book1 = GetBook("Book 1");
        }
    }
}
