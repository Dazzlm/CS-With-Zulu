
using CS_With_Zulu;

Console.WriteLine("=============");
Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");



Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Monica",
    LastName = "Galindo",
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


Console.WriteLine(employee1);
Console.WriteLine(employee2);