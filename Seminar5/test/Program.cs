Console.Clear();
Console.WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(Console.ReadLine());
while (size < 1 || size > 100)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    size = Convert.ToInt32(Console.ReadLine());
}
int[] number = new int[size];
FillArrayRandomNumbers(number);
Console.WriteLine("Массив: ");
PrintArray(number);
void FillArrayRandomNumbers(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToInt32(new Random().Next(1, 32));
    }
}
void PrintArray(int[] number)
{
    Console.Write("[ ");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int f = 0; // 4
int t = 0; // 3
for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        f++;
    }
    else
    {
        t++;
    }
}
int[] fourArray = new int[f];
int[] threeArray = new int[t];

int fourIndex = 0;
int threeIndex = 0;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        fourArray[fourIndex] = number[i];
        fourIndex++;
    }
    else
    {
        threeArray[threeIndex] = number[i];
        threeIndex++;
    }
}
// Console.WriteLine($"Даты зачетов: [{string.Join(", ", array)}]");
Console.WriteLine($"Даты, когда получали оценку 4 :  [{string.Join(", ", fourArray)}]");
Console.WriteLine($"Даты, когда получали оценку 3 :  [{string.Join(", ", threeArray)}]");
if (f > t)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}