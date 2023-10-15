using System;

class Program
{
    static void Main()
    {
        try
        {
            CallerMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение в вызывающем методе: {ex.Message}");
        }
    }

    static void CallerMethod()
    {
        try
        {
            CalleeMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение в вызываемом методе: {ex.Message}");
            throw; // Поднимаем исключение обратно в вызывающий метод
        }
    }

    static void CalleeMethod()
    {
        throw new Exception("Генерируем исключение в вызываемом методе.");
    }
}
