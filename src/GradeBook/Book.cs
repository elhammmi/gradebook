using Microsoft.VisualBasic;

namespace GradeBook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        
        public void ShowStatistics()
        {
            var result = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;
            foreach (var number in grades)
            {   
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result = result + number;
            }
            var averageResult = result/ grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {averageResult}");

        }

        private List<double> grades;
    }
}