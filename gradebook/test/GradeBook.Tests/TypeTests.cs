using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        #region Tests


        [Fact] 
        public void CSharpCanPassByRef()
        {
            // This method passes the reference of variable book1 to the method
            // This connects the local variable used by the method and the variable that was passed as an argument.
            // If you change the local variable on the GetBookSetName method, it changes the variable book1 outside of the method.
            // This essentially says that instead of passing a copy of the value of the variable, you are passing the variable itself.

            var book1 = GetBook("Book 1");

            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        // Notice that the method below has the same name as another method, but received different parameters.
        // This is called Method Overloading, where a method can accept different parameters or even have differnt types of returns. 
        // Then they can display different behavior according to what they receive.
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CSharpIsPassByValue()
        {
            // Proof that changing the variable passed as an argument inside the method doesn't affect the original variable.
            // Because it is a copy of the value of the original variable and not the variable itself.
            var book1 = GetBook("Book 1");

            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void VariablePointerConceptTest()
        {
            // When you have book1 pointing to a Book Object, then you assign book2 to point to book1
            // If you update book1 to point to another object, book2 still remains pointed to what book1 was pointing before
            // So when you assign something to a variable, you are assigning the value / reference to the variable and not connecting them with each other.

            var book1 = GetBook("Book 1");
            var book2 = book1;

            book1 = GetBookReturnBook(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void GetBooksWithSameNameButDifferentObjects()
        {
            var book1 = GetBook("Book");
            var book2 = GetBook("Book");

            Assert.Equal(book1.Name, book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        #endregion

        #region Test Helpers

        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private Book SetName(Book book, string name)
        {
            book.Name = name;
            return book;
        }
        private Book GetBookReturnBook(Book book, string name)
        {
            return book = new Book(name);
        }

        #endregion
    }
}
