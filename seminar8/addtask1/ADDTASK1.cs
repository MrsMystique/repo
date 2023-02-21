// МАССИВ M*N. m и n примем с консоли. в типе инт
// данные в массиве за полняются диагоналями. числа идут тупо по порядку не рандомно
// возьмем матрицу 3 на 3 и нарисуем  эту красоту. потом разберемся
/*
0 1 3
2 4 6
5 7 8 ???? 8???
что я вижу? я вижу проблему, где числа не могут генериться по порядку
им нужна какая то зависимость... от счетчика...хм..это может быть счетчик но 
сторонний... отличный от индекса
*/

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear(); 
// окей. примем размер матрицы
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице");
int column = Convert.ToInt32(Console.ReadLine());
// обьявим матрицу
int[,] matrix = new int[row, column];
// пока не ясно для чего создадим вложенные циклы для перебора
// распечатаем индексы этой матрицы для хоть какого то понимания сути

for (int i = 0; i < row; i++)
{ 
    Console.WriteLine("\n");
    for (int j = 0; j < column; j++)
    {
        Console.Write($"[{i},{j}] = {((i+j)*2)+1} \t");
    }
}

/*for (int i = 0; i < row; i++)
{ 
    Console.WriteLine("\n");
    

    for (int j = 0; j < column; j++)
    {
        if (i == 0 && j == 0)
        {
            Console.Write($"{matrix[i , j] = 0} \t");
        }
        else
        {
            matrix[i,j] = ((i+j)*2)+1;
        }
        
        Console.Write($"{matrix[i,j]} \t");
        
         
    }
}*/