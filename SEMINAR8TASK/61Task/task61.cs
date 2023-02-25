//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

   
Console.Write("Введите количество строк треугольника Паскаля: ");
 
int rows = Convert.ToInt32(Console.ReadLine());
 
 
for (int rowNum = 0; rowNum < rows; rowNum++)
{
    int StartValue = 1;
    for (int i = 0; i < rows - rowNum; i++)
    {
        Console.Write("   ");
    }
 
    for (int element = 0; element <= rowNum; element++)
    {
        Console.Write("   {0:D}  ", StartValue); // форматирование целочисленных значений
        StartValue = StartValue * (rowNum - element) / (element + 1);// расчет чисел для заполнения
    }
    Console.WriteLine();
    Console.WriteLine();
}
