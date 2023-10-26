public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public void ListStudentInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Student's name: {Name}");
        Console.WriteLine($"Student's surname: {Surname}");
    }
}