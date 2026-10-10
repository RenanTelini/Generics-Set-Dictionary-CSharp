using CourseAndStudentWithHashSet.Entities;

namespace CourseAndStudentWithHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> studentSet = new HashSet<Student>();
            Student student = new Student();

            try
            {
                Console.Write("How many students for course A?: ");
                int n = int.Parse(Console.ReadLine());

                student.InsertStudent(ref studentSet, n);

                Console.Write("How many students for course B?: ");
                n = int.Parse(Console.ReadLine());

                student.InsertStudent(ref studentSet, n);

                Console.Write("How many students for course C?: ");
                n = int.Parse(Console.ReadLine());

                student.InsertStudent(ref studentSet, n);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Total students: " + studentSet.Count);
        }
    }
}