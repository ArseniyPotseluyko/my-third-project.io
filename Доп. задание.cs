using System;

class HexadecimalCounter
{
    // Поля
    private int value;
    private int minValue;
    private int maxValue;

    // Конструктор по умолчанию
    public HexadecimalCounter()
    {
        value = 0;
        minValue = 0;
        maxValue = 255; // Максимальное значение для одного байта (FF в шестнадцатеричном формате)
    }

    // Конструктор с произвольными значениями
    public HexadecimalCounter(int initialValue, int minValue, int maxValue)
    {
        if (initialValue < minValue || initialValue > maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(initialValue), "Начальное значение должно быть в пределах диапазона.");
        }

        this.value = initialValue;
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    // Свойство для получения текущего значения
    public string CurrentValue => value.ToString("X"); // Преобразование в шестнадцатеричный формат

    // Метод для увеличения значения на единицу
    public void Increment()
    {
        if (value < maxValue)
        {
            value++;
        }
        else
        {
            Console.WriteLine("Достигнуто максимальное значение.");
        }
    }

    // Метод для уменьшения значения на единицу
    public void Decrement()
    {
        if (value > minValue)
        {
            value--;
        }
        else
        {
            Console.WriteLine("Достигнуто минимальное значение.");
        }
    }

    // Метод для отображения состояния счетчика
    public void DisplayState()
    {
        Console.WriteLine($"Текущее значение: {CurrentValue}, Диапазон: {minValue.ToString("X")} - {maxValue.ToString("X")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Демонстрация работы с шестнадцатеричным счетчиком
        Console.WriteLine("Создание счетчика со значениями по умолчанию...");
        HexadecimalCounter defaultCounter = new HexadecimalCounter();
        defaultCounter.DisplayState();

        Console.WriteLine("\nУвеличение значения:");
        defaultCounter.Increment();
        defaultCounter.DisplayState();

        Console.WriteLine("\nУменьшение значения:");
        defaultCounter.Decrement();
        defaultCounter.DisplayState();

        Console.WriteLine("\nСоздание счетчика с произвольными значениями...");
        HexadecimalCounter customCounter = new HexadecimalCounter(10, 0, 100);
        customCounter.DisplayState();

        Console.WriteLine("\nУвеличение значения:");
        customCounter.Increment();
        customCounter.DisplayState();

        Console.WriteLine("\nУменьшение значения:");
        customCounter.Decrement();
        customCounter.DisplayState();
    }
}