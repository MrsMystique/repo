/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такой позиции в массиве нет
1 2 -> На данной позиции находиться элемент 4*/
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

// ищет элемент на указанной пользователем позиции

    Console.WriteLine("Введите номер строки для поиска элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца для поиска элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Позиция для поиска элемента определена. Ищу элемент [{row},{column}] ");
    // если и будет сразу больше длинны массива...в цикл я зне зайду. следовательно мне нужно обработать это исключение
      
    while (row>= size[0] || column >= size[1])
    {
        Console.WriteLine($"Позиция не найдена. Матрица имеет {size[0]} строк и {size[1]} столбцов");
        
        if (row >= size[0] || column >= size[1])
        { 
            Console.WriteLine("Продублировать вам матрицу? Y/N: ");
            char answer = Convert.ToChar(Console.ReadLine());
       
            if (answer =='Y' || answer == 'y')
            {
                PrintMatrix(matrix);
                Console.WriteLine("Введите повторно номер строки для поиска: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите повторно номер столбца для поиска: ");
                column = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"Напоминаю, последний индекс строки в этой матрице {size[0]-1}, а последний индекс столбца {size[0]-1}");
                Console.WriteLine("Введите повторно номер строки для поиска: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите повторно номер столбца для поиска: ");
                column = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    if (row < size[0] || column < size[1])
    {
        Console.WriteLine($"Элемент [{row},{column}] найден: {matrix[row, column]}");
    }
   
