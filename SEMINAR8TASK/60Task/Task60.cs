/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int FillArrayWithUniqNumber(int[] matrix)
{
    int nextNumber;
    do
    {
        nextNumber = new Random().Next(10, 100);// только  двухзначные
    }
    while (matrix[nextNumber] != 0);
    matrix[nextNumber] = 1;
    return nextNumber;
}
int[,,] Generate3DArray(int rows, int columns, int layer, int[] matrix3d)
{
    int[,,] returnArray = new int[rows, columns, layer];

    if (rows * columns * layer < 90) // макс количество ячеек в матрице
    {
        for (int i = 0; i < returnArray.GetLength(0); i++)
        {
            for (int j = 0; j < returnArray.GetLength(1); j++)
            {
                for (int k = 0; k < returnArray.GetLength(2); k++)
                {
                    returnArray[i, j, k] = FillArrayWithUniqNumber(matrix3d);
                }
            }
        }
    }
   
    return returnArray;

}
void Print3DArray(int[,,] int3DArray)
{
    for (int i = 0; i < int3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int3DArray.GetLength(1); j++)
        {
            for (int k = 0; k < int3DArray.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {int3DArray[i, j, k]} ");
            }
            Console.WriteLine();
        }
        
    }
}
Console.Clear();
int[] array1D = new int[100];
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество слоев в матрице: ");
int layer = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = Generate3DArray(row, column, layer, array1D);
Print3DArray(array3D);



