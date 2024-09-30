List<Employee> employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1001,
        Name = "Priyanka",
        Salary = 80000
    },
    new Employee()
    {
        Id = 1002,
        Name = "Anurag",
        Salary = 90000
    },
    new Employee()
    {
        Id = 1003,
        Name = "Preety",
        Salary = 80000
    }
};
// The LINQ query is executed immediately as we're using ToList() method
var result = (from employee in employees
    where employee.Salary > 80000
    select employee).ToList();

employees.Add(new Employee(){Id = 1004, Name = "Casio", Salary = 85000});
// The above LINQ query is executed at the time of its creation
// Casio is not included in the result
foreach (var emp in result)
{
    Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Salary}");
}

public class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Salary { get; set; }
}