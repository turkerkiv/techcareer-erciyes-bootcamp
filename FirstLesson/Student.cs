public class Student : Person
{
    public Student(int id, string name, string surname) : base(id, name, surname)
    {
    }

    public override void ListPersonInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Student's name: {Name}");
        Console.WriteLine($"Student's surname: {Surname}");
    }
}