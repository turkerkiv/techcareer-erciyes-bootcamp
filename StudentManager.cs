using System.ComponentModel;
using System.Data.Common;
using System.Dynamic;

public class StudentManager
{
    private List<Student> students = new List<Student>();
    public List<Student> Students { get { return students; } }

    public void AddStudent()
    {
        Console.WriteLine("Enter the id of student");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Enter the name of student");
        string name = Console.ReadLine().ToString();
        Console.WriteLine("");

        Console.WriteLine("Enter the surname of student");
        string surname = Console.ReadLine().ToString();
        Console.WriteLine("");

        Student newSt = new Student()
        {
            Id = id,
            Name = name,
            Surname = surname,
        };

        students.Add(newSt);

    }

    public void ListAllStudents()
    {
        foreach (Student st in students)
        {
            st.ListStudentInfo();
            Console.WriteLine("");
        }
    }
}