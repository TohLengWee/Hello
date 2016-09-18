using System.Collections.Generic;
using System.IO;

namespace Hello
{
    public abstract class GradeTracker : IGradeBook
    {
        public abstract void AddGrade(float grade);
        public abstract GradeBookStatistics ComputeGradeBookStatistics();
        public abstract void WriteGrade(TextWriter output);

        protected string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs
                        {
                            ExistingName = _name,
                            NewName = value
                        };
                        NameChanged(this, args);
                    }

                    _name = value;
                }
            }
        }

        public event NameChangedDeletegator NameChanged;

        protected List<float> Grades { get; } = new List<float>();
    }
}
