namespace Hello
{
    public class GradeBookStatistics
    {
        public float HighestGrade { get; set; }
        public float LowestGrade { get; set; }
        public float AverageGrade { get; set; }

        public char LetterGrade
        {
            get
            {
                if (AverageGrade >= 90)
                {
                    return 'A';
                }
                if (AverageGrade >= 80)
                {
                    return 'B';
                }
                if (AverageGrade >= 70)
                {
                    return 'C';
                }
                return 'F';
            }
        }
    }
}
