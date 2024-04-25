
using MiniTest;

var employees = new List<Employee>()
{
    new Employee(1, "Brynn", new Department(1, "IT"), "Software Engineer"),
    new Employee(2, "Aaron", new Department(1, "IT"), "Senior Software Engineer"),
    new Employee(3, "Zach", new Department(2, "Legal"), "Attorney"),
    new Employee(4, "Cameron", new Department(3, "HR"), "Business Analyst"),
};

foreach (var employee in employees)
{

   Console.WriteLine(employee);
}






