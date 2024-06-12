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
        book.ShowStatistics();
    }
}
