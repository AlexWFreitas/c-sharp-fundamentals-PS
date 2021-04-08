using System;
using Xunit;
using System.Collections.Generic;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Book book = new Book("Book Name");

            // Act ( Kinda )
            book.AddGrades(new List<double>() { 20, 30, 60, 50 } );
            double average = book.GetStatistics().Average;

            // Assert
            Assert.Equal(40, average);
        }
    }
}
