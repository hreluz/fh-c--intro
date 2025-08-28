partial class Program
{
    public static void Inheritance()
    {
        Student student = new Student() { Name = "Bruce", House = "Wayne" };
        Profesor profesor = new Profesor() { Name = "Alfred", Subject = "Modals" };

        student.Greet();
        student.ShowHouse();

        profesor.Greet();
        profesor.MySubject();

    }
}

class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        WriteLine($"Hello, I am {Name}");
    }
}

class Student : Character
{
    public string? House { get; set; }
    public void ShowHouse()
    {
        WriteLine($"I belong to {House}");
    }
}

class Profesor : Character
{
    public string? Subject { get; set; }
    public void MySubject()
    {
        WriteLine($"I teach {Subject}");
    }
}