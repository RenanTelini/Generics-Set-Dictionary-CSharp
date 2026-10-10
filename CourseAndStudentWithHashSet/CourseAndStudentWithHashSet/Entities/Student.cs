namespace CourseAndStudentWithHashSet.Entities
{
    class Student
    {
        public int StudentID { get; set; }

        public Student()
        {
        }

        public Student(int studentID)
        {
            StudentID = studentID;
        }

        public void InsertStudent(ref HashSet<Student> studentSet, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                studentSet.Add(new Student(int.Parse(Console.ReadLine())));
            }
        }

        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
                return false;

            Student other = obj as Student;
            return StudentID.Equals(other.StudentID);
        }
    }
}