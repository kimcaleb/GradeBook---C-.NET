using System;
using Xunit;


namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);
            Assert.Equal(3,x);
        }

        private void SetInt(int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //act
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);


        }
        private void SetName(Book book, string name)
        {   
            book.Name = name;
        }
        [Fact]
        public void CSharpIsPassByValue()
        {
            //act
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book 1", book1.Name);
        }   
        private void GetBookSetName(Book book, string name)
        {   
            book = new Book(name);
        }
        [Fact]
        public void CSharpCanPassByRef()
        {
            //act
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);


        }
        private void GetBookSetName(ref Book book, string name) // What is passed instead of the memory address is a copy of the memory location of where that object is stored. 
        {   
            book = new Book(name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange

            //act
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // assert
            Assert.Same(book1,book2);

        }

        // [Fact]

        Book GetBook(string name) 
        {
            return new Book(name);
        }


    }
}
