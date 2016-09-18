using System.Linq;

namespace Hello
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeBookStatistics ComputeGradeBookStatistics()
        {
            Grades.Remove(Grades.Min());
            return base.ComputeGradeBookStatistics();
        }
    }
}
