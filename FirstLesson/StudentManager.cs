using System.ComponentModel;
using System.Data.Common;
using System.Dynamic;

public class StudentManager
{
    private List<Person> students = new List<Person>();
    public List<Person> Students { get { return students; } }

    public StudentManager()
    {
        students.Add(new Person(0, "Polymorphism", "test"));
    }

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

        Student newSt = new Student(id, name, surname);

        students.Add(newSt);
    }

    public void ListAllStudents()
    {
        foreach (Person pr in students)
        {
            pr.ListPersonInfo();
            Console.WriteLine("");
        }
    }

    public T GetAnything<T>(T anything)
    {
        return anything;
    }
}