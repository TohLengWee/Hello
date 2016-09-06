using System.Collections.Generic;

namespace Hello
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public List<float> Grades { get; } = new List<float>();
    }
}
