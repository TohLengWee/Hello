using System.IO;
using System.Linq;

namespace Hello
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "English";
        }

        public override void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public override GradeBookStatistics ComputeGradeBookStatistics()
        {
            GradeBookStatistics statistics = new GradeBookStatistics
            {
                AverageGrade = Grades.Average(),
                HighestGrade = Grades.Max(),
                LowestGrade = Grades.Min()
            };

            return statistics;            
        }

        public override void WriteGrade(TextWriter output)
        {
            foreach (var grade in Grades)
            {
                output.WriteLine(grade);
            }            
        }
    }
}
