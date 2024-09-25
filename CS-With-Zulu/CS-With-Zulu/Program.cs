
using CS_With_Zulu;

Console.WriteLine("=============");
Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2022, 9, 11));
    Console.WriteLine(new Date(2052, 8, 11));
    Console.WriteLine(new Date(2022, 1, 32));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
	
}

