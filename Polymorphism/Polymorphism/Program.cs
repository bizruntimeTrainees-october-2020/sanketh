using System;

public class Employee
{
    public string Firstname = "FN";
    public string Lastname = "LN";
    public void 
        PrintFullname()
    {
        Console.WriteLine(Firstname + " " + Lastname);
    }
}
public class PartTimeEmployee : Employee
{
}
public class FullTimeEmployee : Employee
{
}
public class TemporaryTimeEmployee : Employee
{
}
public class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryTimeEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullname();
        }
    }
}





