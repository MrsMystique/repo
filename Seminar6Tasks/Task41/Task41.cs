/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.Clear();
Console.WriteLine("Введите количество чисел, которые вы введете\nдалее программа закончит подсчет: ");
int Max = Convert.ToInt32(Console.ReadLine());

int number = 0;
int countPositive = 0;
// добавляю его в список
List<int> numbersList = new List<int>(1);


for (int i = 0; i < Max; i++)
{  
    Console.WriteLine("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        countPositive++;
    }
    numbersList.Add(number);
       
}
Console.WriteLine($"Текущее состояние списка: [{string.Join(", ", numbersList)}]");
Console.WriteLine($"Вы ввели {countPositive} чисел больше нуля");



