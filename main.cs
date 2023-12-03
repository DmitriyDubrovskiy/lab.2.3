using System;

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void DisplayInformation(string position, int experience)
    {
        double baseSalary = 50000;  // Приклад базового окладу
        double taxRate = 0.15;  // Податковий збір (15%)

        // Розрахунок окладу залежно від посади та стажу
        double salary = baseSalary + (experience * 1000);  // Приклад розрахунку

        // Розрахунок податкового збору
        double tax = salary * taxRate;

        // Виведення інформації на екран
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {salary:C}");
        Console.WriteLine($"Податковий збір: {tax:C}");
    }
}
