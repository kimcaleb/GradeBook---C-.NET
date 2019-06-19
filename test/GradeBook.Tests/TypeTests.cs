using System;
using Xunit;


namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact] // This is called an attribute in C#. This of an attribute as a little piece of data attached to the symbol that follows it. So "Fact" is a little piece of data that is attached to the method Test1(). When xUnit loads up your test project and tries to find the test inside and execute them, and telling you whether they passed or failed, it will look for methods that have this [Fact] attribute attached. 
        public void GetBookRetunsDifferentObjects()
        {
            //arrange

            //act
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);

        }

        public void TwoVarsCanReferenceSameObject()
        {
            //arrange

            //act
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // assert
            Assert.Same(book1,book2);

        }
        Book GetBook(string name) 
        {
            return new Book(name);
        }
    }
}
