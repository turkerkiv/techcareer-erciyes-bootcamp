public class Student
{
    private int _id;
    private string _name;
    private string _surname;

    public int Id { get { return _id; } }
    public string Name { get { return _name; } }
    public string Surname { get { return _surname; } }

    public Student(int id, string name, string surname)
    {
        _id = id;
        _name = name;
        _surname = surname;
    }

    public void ListStudentInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Student's name: {Name}");
        Console.WriteLine($"Student's surname: {Surname}");
    }
}