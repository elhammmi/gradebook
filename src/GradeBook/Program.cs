using GradeBook;

namespace gradebook;

class Program
{
    static void Main(string[] args)
    {
        var book = new Book();
        book.AddGrade(12);
        book.AddGrade(30);
        book.AddGrade(23.4);
        book.AddGrade(12.8);
        var result = book.GetStatistics();
        Console.WriteLine($"The lowest grade is {result.Low}");
        Console.WriteLine($"The highest grade is {result.High}");
        Console.WriteLine($"The average grade is {result.Average}");
    }
}
