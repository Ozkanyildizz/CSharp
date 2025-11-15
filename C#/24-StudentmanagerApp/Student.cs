/*
--- Student Report Table ---
Student Name       Exam 1    Exam 2     AverageGrade letter
-----------------------------------------------------------
özkan                  56       100       78,00      B ****
yıldız                 78        56       67,00       C ***
-----------------------------------------------------------
Sınav Ort.          67,00     78,00

Maximum grade: 100
Minimum grade:  56
             */
namespace StudentmanagerApp
{
    class Student
    {
        private string studentName;
        public string Name { get {return studentName; } private set { studentName = value; } }
        public Student(string SName) { Name = SName ; }
        
        // public override string ToString() => $"Student Name: {Name}";
    }
}
