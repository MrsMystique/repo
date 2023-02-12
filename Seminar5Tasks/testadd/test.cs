Console.Clear();
// функция заполнит массив порядковыми номерами дней месяца в которые Вася получал оценки
void INPUTARRAY(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 32); // [положительные трехзначные]
    }
        
}
//----------------------------------------------------------------------------------------       
//Принять N – количество элементов исходного массива (1 ≤ N ≤ 100)
Console.WriteLine("Введите количество дней от 1 до 100,\nв которые Вася получал оценки по английскому языку: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1 || N > 100)
{
    Console.Write("Вы ошиблись!\nВведите количество дней от 1 до 100: ");
    N = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[N];

List<int> Even = new List<int>(1);
List<int> Odd = new List<int>(1);
int countEven = 0;
int countOdd = 0;
INPUTARRAY(array); 
Console.WriteLine($"Начальный массив: {string.Join(" ", array)}");

for (int i = 0; i < array.Length; i++)
{ 
         if (array[i] % 2 == 0)
        {
            Even.Add(array[i]);
            countEven++;
        }
        else
        {
            Odd.Add(array[i]);
            countOdd++;
        }

}
Console.WriteLine($"Список дней, когда Вася получил 4 балла: {string.Join(" ", Even)}, у Васи {countEven} четверок");

Console.WriteLine($"Список дней, когда Вася получил 3 балла: {string.Join(" ", Odd)}, у Васи {countOdd} троек");

Console.Write("Сравниваю количество 4 и 3, выставляю оценку по большему количеству той или иной отметки -->> ");

if (countEven >= countOdd)
{
    Console.WriteLine($"Вася получит 4 балла за четверть");
}
else
{
    Console.WriteLine($"Вася балбес, у него опять 3 балла");
}




