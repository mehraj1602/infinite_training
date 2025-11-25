// See https://aka.ms/new-console-template for more information
using static CodingTest3.Class1;

IEmployeeDataReader reader = new MockEmployeeDataReader();
PayrollProcessor processor = new PayrollProcessor(reader);
Console.WriteLine(processor.CalculateTotalCompensation(101));
Console.WriteLine(processor.CalculateTotalCompensation(102));
Console.WriteLine(processor.CalculateTotalCompensation(103));
Console.WriteLine(processor.CalculateTotalCompensation(104));
Console.ReadLine();
