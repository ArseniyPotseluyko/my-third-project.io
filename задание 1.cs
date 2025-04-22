using System;

class A
{
    private int a;
    private int b;

    // Конструктор для инициализации a и b
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    // Метод вычисления разности a и b
    public int CalculateDifference()
    {
        return a - b;
    }

    // Метод вычисления значения выражения (a + b) / (a - b)
    public double CalculateExpression()
    {
        if (a - b == 0) // Проверка на деление на ноль
        {
            throw new DivideByZeroException("Разность a и b равна 0, деление невозможно.");
        }
        return (double)(a + b) / (a - b);
    }

    // Метод для вывода значений a и b
    public void DisplayValues()
    {
        Console.WriteLine($"a = {a}, b = {b}");
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта класса A
        Console.WriteLine("Введите значения a и b:");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        A obj = new A(a, b);

        // Работа с элементами класса
        obj.DisplayValues(); // Вывод значений a и b
        Console.WriteLine($"Разность a и b: {obj.CalculateDifference()}");

        try
        {
            Console.WriteLine($"Значение выражения (a + b) / (a - b): {obj.CalculateExpression():F4}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
