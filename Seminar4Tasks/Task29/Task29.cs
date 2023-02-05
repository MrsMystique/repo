/*Входные данные
1) натуральное число N (N ≤ 100) – количество учеников (не считая Петю). 
2) N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах в порядке убывания. 
3) натуральное число X (X ≤ 200) – рост Пети.

Выходные данные
единственное целое число – номер Пети в шеренге учеников.*/
Console.Clear();
Console.Write("Введите число учеников: ");
int numberStudents = Convert.ToInt32(Console.ReadLine());

//Проверка(1) натуральное число N (N ≤ 100) – количество учеников (не считая Петю). ))
while (numberStudents > 100)
{
    Console.Write("Введите число учеников меньше или равно 100: ");
    numberStudents = Convert.ToInt32(Console.ReadLine());
}
int[] StudentsHeight = new int [numberStudents];
int HigherStudents = 0;
int LowerStudents = 0;
// Array check--------------------------------------------------------
void print_array(int[] array) 
{
    Console.Write("[");
    int index = 0;
    while (index < array.Length) 
    {
        Console.Write($"{array[index]}, ");
        index += 1;
    }
    Console.Write("\b\b]\n");
}
Console.Write("вот объявленный массив -->> ");
print_array(StudentsHeight);
// --------------------------------------------------------
// Проверка(Ai (Ai ≤ 200) – рост учеников в сантиметрах) 

for (int k = 0; k < numberStudents; k++)
{     
    Console.WriteLine($"Введите рост {k+1} студентa: ");
    StudentsHeight[k] = Convert.ToInt32(Console.ReadLine());
    
    // добавлена проверка на очень низкий рост студентов (экспромт)
    while (StudentsHeight[k] <= 100 || StudentsHeight[k] >= 200)
    {
        Console.Write($"Мы не в белоснежке и {numberStudents} гномов или у нас нет баскетболистов. ВВедите нормальный рост студентов: "); 
        StudentsHeight[k] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Вывожу студентов и их рост: \n");
Console.WriteLine(" No.Student" + " Рост");

for (int j = 0; j < numberStudents; j++)
{
    Console.WriteLine ((j+1) + "\t" + StudentsHeight[j]);
}
Console.WriteLine();
Console.WriteLine("Введите свой рост: ");
int YourHeight = Convert.ToInt32(Console.ReadLine());
    // добавлена проверка на очень низкий рост студентов (экспромт)
while (YourHeight <= 100 || YourHeight >= 200)
{
        Console.Write($"Вы вполне стандартный человек. ВВедите нормальный рост : "); 
        YourHeight = Convert.ToInt32(Console.ReadLine());
}
// сравниваю элементы массива с ростом Пети, считаю сколько больше а сколько мешьше
for (int i = 0; i < numberStudents; i++)
{
    if (YourHeight < StudentsHeight[i])
    {
        HigherStudents++;
    }
    else
    {
        LowerStudents++;
    }
}
Console.WriteLine($"ИТОГО: Ниже вас {LowerStudents} студента");
Console.WriteLine($"ИТОГО: Выше вас {HigherStudents} студента");
Console.WriteLine($"Ваша позиция в строю {HigherStudents + 1}");

