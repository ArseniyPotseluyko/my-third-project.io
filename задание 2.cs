using System;

// Базовый класс: Персона
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Персона: {Name}, Возраст: {Age}");
    }
}

// Производный класс: Служащий
class Employee : Person
{
    public string Department { get; set; }

    public Employee(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Служащий: {Name}, Возраст: {Age}, Отдел: {Department}");
    }
}

// Производный класс: Инженер
class Engineer : Employee
{
    public string Specialization { get; set; }

    public Engineer(string name, int age, string department, string specialization)
        : base(name, age, department)
    {
        Specialization = specialization;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Инженер: {Name}, Возраст: {Age}, Отдел: {Department}, Специализация: {Specialization}");
    }
}

// Производный класс: Рабочий
class Worker : Person
{
    public string Position { get; set; }

    public Worker(string name, int age, string position)
        : base(name, age)
    {
        Position = position;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Рабочий: {Name}, Возраст: {Age}, Должность: {Position}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов каждого класса
        Person person = new Person("Алексей", 45);
        Employee employee = new Employee("Мария", 30, "Финансовый");
        Engineer engineer = new Engineer("Дмитрий", 35, "Технический", "Механика");
        Worker worker = new Worker("Иван", 40, "Сборщик");

        // Демонстрация иерархии
        Console.WriteLine("Демонстрация иерархии классов:");
        person.ShowInfo();
        employee.ShowInfo();
        engineer.ShowInfo();
        worker.ShowInfo();
    }
}