//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Clear();
Console.Write("Введите количество строк: ");
void PrintPascalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        int number = 1;
        Console.Write("".PadLeft((n - i - 1) * 2));

        for (int j = 0; j <= i; j++)
        {
            Console.Write(number + "   ");
            number = number * (i - j) / (j + 1);
        }

        Console.WriteLine();
    }
}

int rows = int.Parse(Console.ReadLine());
PrintPascalTriangle(rows);

