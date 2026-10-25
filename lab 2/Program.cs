using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ==========================================
        // ЗАВДАННЯ 4а:
        // Натуральне число n ділиться на 3. Якщо воно ділиться на 5, 
        // то не ділиться на 9; якщо ділиться на 9, то ділиться на 7.
        // ==========================================
        Console.WriteLine("--- Завдання 4а ---");
        Console.Write("Введіть натуральне число n: ");
        int n = int.Parse(Console.ReadLine());

        // Логічний вираз для пункту 'а'
        // (n ділиться на 3) AND (якщо ділиться на 5, то не ділиться на 9) AND (якщо ділиться на 9, то ділиться на 7)
        // Імплікація (A => B) еквівалентна (!A || B)
        bool conditionA = (n % 3 == 0) &&
                          (!(n % 5 == 0) || (n % 9 != 0)) &&
                          (!(n % 9 == 0) || (n % 7 == 0));

        // Використання тернарної операції для виведення TRUE / FALSE
        string resultA = conditionA ? "TRUE" : "FALSE";
        Console.WriteLine($"Результат 4а: {resultA}\n");


        // ==========================================
        // ЗАВДАННЯ 4б:
        // Круг радіусу R вписаний в квадрат зі стороною a.
        // Перевіряємо умову геометричної сумісності (сторона квадрата має бути дорівнювати 2 * R)
        // ==========================================
        Console.WriteLine("--- Завдання 4б ---");
        Console.Write("Введіть радіус круга R: ");
        double R = double.Parse(Console.ReadLine());

        Console.Write("Введіть сторону квадрата a: ");
        double a = double.Parse(Console.ReadLine());

        // Круг може бути вписаний у квадрат, якщо сторона квадрата рівна діаметру круга (a == 2 * R)
        // З урахуванням похибки для дійсних чисел:
        bool conditionB = (Math.Abs(a - 2 * R) < 1e-7) && (R > 0);

        // Використання умовного оператора if-else
        string resultB;
        if (conditionB)
        {
            resultB = "TRUE";
        }
        else
        {
            resultB = "FALSE";
        }

        Console.WriteLine($"Результат 4б: {resultB}");
    }
}
