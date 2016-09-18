using System.IO;

namespace Hello
{
    public interface IGradeBook
    {
        void AddGrade(float grade);
        GradeBookStatistics ComputeGradeBookStatistics();
        void WriteGrade(TextWriter output);
    }
}
