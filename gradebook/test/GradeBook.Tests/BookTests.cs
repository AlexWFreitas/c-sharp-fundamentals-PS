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
            InMemoryBook book = new InMemoryBook("Book Name");

            // Act ( Kinda )
            book.AddGrades(new List<double>() { 20, 30, 60, 50 } );
            double average = book.GetStatistics().Average;

            // Assert
            Assert.Equal(40, average, 1);
        }

        [Fact]
        public void BookCalculatesAnAverageGradeWithDecimals()
        {
            InMemoryBook book = new InMemoryBook("Book Name");

            book.AddGrades(new List<double>() { 20.5, 30.1, 60.3, 50.75 });
            double average = book.GetStatistics().Average;

            Assert.Equal(40.41, average, 2);
        }

        [Fact]
        public void BookDoesntAddGradeAbove100()
        {
            InMemoryBook book = new InMemoryBook("TestBook");
            double grade = 101;

            Assert.Throws<ArgumentException>(() => book.AddGrade(grade));
            // Cadastrar uma fun??o que vai disparar quando ocorrer uma exce??o.

            Assert.Empty(book.Grades);
        }

        [Fact]
        public void BookDoesntAddGradeBelowZero()
        {
            InMemoryBook book = new InMemoryBook("TestBook");
            double grade = -1;

            Assert.Throws<ArgumentException>(() => book.AddGrade(grade));
            Assert.Empty(book.Grades);
        }

        [Fact]
        public void BookCalculatesAnLowestGrade()
        {
            InMemoryBook book = new InMemoryBook("Book Name");

            book.AddGrades(new List<double>() { 20.5, 30.1, 60.3, 50.75, 0.01 });
            double min = book.GetStatistics().Lowest;

        }


        [Fact]
        public void BookReceivesCorrectName()
        {
            InMemoryBook book = new InMemoryBook("Name of Book");

            Assert.Equal("Name of Book", book.Name);        
        }

        [Fact]
        public void BookAddGradeByLetter()
        {
            InMemoryBook book = new InMemoryBook("Letter Grade");

            book.AddGrade('A');

            Assert.Equal(90, book.Grades[0]);
        }

        [Fact]
        public void BookCalcAverageGradeLetter()
        {
            InMemoryBook book = new InMemoryBook("Letter Grade");

            book.AddGrades(new List<double>() { 80.5, 80.1, 80.3, 90.75, 80.01 });

            Assert.Equal( 'B', Statistics.CalcGradeLetter(book.Grades) );
        }

        [Fact]
        public void BookChangeNameToNull()
        {
            InMemoryBook book = new InMemoryBook("Names");


            Assert.Throws<ArgumentException>(() => book.Name = "");
        }

        [Fact]
        public void BookCantStartWithoutName()
        {
            Assert.Throws<ArgumentException>(() => new InMemoryBook(""));
        }
    }
}
