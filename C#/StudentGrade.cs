

namespace students
{
    class StudentGrade
    {
        public string Name { get; set; }
        private int grade;
        string letterGrade;

        public int Grade
        {
            get { return grade; }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
            }
        }
        public string LetterGrade
        {
            get
            {
                if (Grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (Grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (Grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (Grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                return letterGrade;
            }

        }
        public StudentGrade(string name,int İnitialGrade)
        {
            Name = name;
            Grade = İnitialGrade;
        }
    }
}
