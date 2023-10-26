StudentManager studentManager = new StudentManager();

while (true)
{
    Console.WriteLine("1 - Add student");
    Console.WriteLine("2 - List all students");
    Console.WriteLine("3 - Exit");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            studentManager.AddStudent();
            break;
        case 2:
            studentManager.ListAllStudents();
            break;
        case 3:
            Environment.Exit(0);
            break;
    }
}