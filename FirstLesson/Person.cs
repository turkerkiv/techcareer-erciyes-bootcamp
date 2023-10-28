public class Person
{
    private int _id;
    private string _name;
    private string _surname;

    public int Id { get { return _id; } }
    public string Name { get { return _name; } }
    public string Surname { get { return _surname; } }

    public Person(int id, string name, string surname)
    {
        _id = id;
        _name = name;
        _surname = surname;
    }

    public virtual void ListPersonInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Person's name: {Name}");
        Console.WriteLine($"Person's surname: {Surname}");
    }
}