using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] // This is called an attribute in C#. This of an attribute as a little piece of data attached to the symbol that follows it. So "Fact" is a little piece of data that is attached to the method Test1(). When xUnit loads up your test project and tries to find the test inside and execute them, and telling you whether they passed or failed, it will look for methods that have this [Fact] attribute attached. 
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            // assert
           Assert.Equal(85.6, result.Average, 1);
           Assert.Equal(90.5, result.High, 1);
           Assert.Equal(77.3, result.Low, 1);
        }
    }
}
