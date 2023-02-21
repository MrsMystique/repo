/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
        }   
    }
}

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
// Создаем первую матрицу размера row*column . Для первой матрицы вожно количество строк
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[row, column];

// Создаем вторую матрицу.  она должна иметь столбцов столько сколько строк в первой матрице и строк столько, сколько столбцов в первой матрице.
// можно было бы натворить кучу проверок. но я заменю данные  строк и столбцов местами и вуаля. получу нужную матрицу
int[,] matrixB = new int[column, row];
// Заполняю матрицу А. вывожу
InputMatrix (matrixA);
Console.WriteLine("Исходный массив А: ");
PrintMatrix(matrixA);
InputMatrix (matrixB);
Console.WriteLine("Исходный массив B: ");
PrintMatrix(matrixB);
//создаю результирующую матрицу. она равна будет Количество строк в A  и столбцов как в В
int[,] matrixResult = new int[row, row];

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    
    for (int j = 0; j < matrixB.GetLength(1); j++)// итерации верхнего порядка по результ
    {           
        int Sum = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)// итерации по а столбцам
        {
            
            Sum += matrixA[i, k] * matrixB[k, j];
            
        }
           
        matrixResult [i,j] = Sum;
    }
}

    Console.WriteLine(" Смоделирована первая итерация. Результат ");
    PrintMatrix(matrixResult);
   

