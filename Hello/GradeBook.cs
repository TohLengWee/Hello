using System.Collections.Generic;

namespace Hello
{
    class GradeBook
    {
        public GradeBook()
        {
            _name = "English";
        }

        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        private string _name;
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

        public List<float> Grades { get; } = new List<float>();
    }
}
