using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace GradeBook.Tests
{
    public class BookTests
    {
        private readonly ITestOutputHelper output;

        public BookTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // Arrange
            Book book = new Book("Book Name");

            // Act ( Kinda )
            book.AddGrades(new List<double>() { 20, 30, 60, 50 } );
            double average = book.GetStatistics().Average;

            // Assert
            Assert.Equal(40, average, 1);
        }

        [Fact]
        public void BookCalculatesAnAverageGradeWithDecimals()
        {
            Book book = new Book("Book Name");

            book.AddGrades(new List<double>() { 20.5, 30.1, 60.3, 50.75 });
            double average = book.GetStatistics().Average;

            Assert.Equal(40.41, average, 2);
        }

        [Fact]
        public void BookDoesntAddGradeAbove100()
        {
            Book book = new Book("TestBook");
            double grade = 101;


            book.AddGrade(grade);

            Assert.Empty(book.Grades);
        }

        [Fact]
        public void BookDoesntAddGradeBelowZero()
        {
            Book book = new Book("TestBook");
            double grade = -1;


            book.AddGrade(grade);

            Assert.Empty(book.Grades);
        }

        [Fact]
        public void BookReceivesCorrectName()
        {
            Book book = new Book("Name of Book");

            Assert.Equal("Name of Book", book.Name);        }
    }
}
