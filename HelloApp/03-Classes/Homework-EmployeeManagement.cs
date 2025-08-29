partial class Program
{
    public static void Employees()
    {
        Employee teamLeader = new TeamLeader("Charlie", 1000);
        Employee developer1 = new Developer("Ana", 3000);
        Employee teamLeader2 = new TeamLeader("Laura", 4000);
        Employee developer2 = new Developer("Luis", 5000);

        List<Employee> employees = new List<Employee>();
        employees.Add(teamLeader);
        employees.Add(teamLeader2);
        employees.Add(developer1);
        employees.Add(developer2);

        foreach (var employee in employees)
        {
            employee.ShowInfo();
        } 
    }

}

class Employee
{
    protected string Name { get; set; }
    protected double Salary { get; set; }
    protected string Position { get; set; }

    public Employee(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }

    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }

    public void ShowInfo()
    {
        WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary:C} and Calculated bonus {CalculateBonus():C}");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, double salary) : base(name, salary, "Team Leader"){}

    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }
}
class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary, "Developer"){}

    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}