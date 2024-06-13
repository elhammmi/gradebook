namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        var book = new Book();
        book.AddGrade(12.4);
        book.AddGrade(23.5);
        book.AddGrade(32.9);

        //act
        var actuall = book.GetStatistics();
        //assert
        Assert.Equal(22.9, actuall.Average, 1);
        Assert.Equal(12.4, actuall.Low, 1);
        Assert.Equal(32.9, actuall.High, 1);


    }
}