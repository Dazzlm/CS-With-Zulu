
using System.Security.AccessControl;
using CS_With_Zulu;

Console.WriteLine("=============");
Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");



Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Monica",
    LastName = "Smith",
    BirthDate = new Date(1952, 8, 20),
    HiringDate = new Date(1982, 2, 10),
    IsActive = true,
    Salary = 19820254M

};

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Juan",
    LastName = "Jose",
    BirthDate = new Date(1992, 8, 20),
    HiringDate = new Date(2022, 2, 10),
    IsActive = true,
    Sales = 320852438M,
    CommissionPercentaje = 0.03F
};

Employee employee3= new HourlyEmployee()
{
    Id = 3,
    FirstName = "Mariana",
    LastName = "Jose",
    BirthDate = new Date(1989, 3, 20),
    HiringDate = new Date(2019, 2, 15),
    IsActive = true,
    HourValue = 32388M,
    Hours = 12.3F
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4,
    FirstName = "Juliancho",
    LastName = "Giraldo",
    BirthDate = new Date(1999, 3, 10),
    HiringDate = new Date(2019, 01, 15),
    IsActive = true,
    Base = 5832388M,
    CommissionPercentaje = 0.015F
};

ICollection<Employee> employeeList = new List<Employee>()
{
    employee1,employee2,employee3,employee4
};

decimal payroll = 0;

foreach (Employee employee in employeeList)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();


}
  
Console.WriteLine("                                  ===============");
Console.WriteLine($"\tTotal:                    {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "Chorizo",
    Id = 1,
    Price = 14000M,
    Quantity = 5
};

Invoice invoice2 = new Invoice()
{
    Description = "DogChaw",
    Id = 2,
    Price = 59000M,
    Quantity = 2
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);