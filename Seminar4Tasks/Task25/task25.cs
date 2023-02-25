/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать Math.Pow();
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int B = Convert.ToInt32(Console.ReadLine());

int RecursionPower(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    else
    {
         return A*RecursionPower(A, B-1);
    }
}
Console.WriteLine(RecursionPower(A,B));
