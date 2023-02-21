// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=8&id_topic=121&id_problem=749
// у нас будет создана матрица типа чар размер которой введет пользователь (для исходного массива и для рандомного)
// описание изображения это будет тоже массив такого же типа, котрый наш Миша будет заполнять руками символами W - белый  и B- черный
// Во второй массив символы будут рандомно занесены...как...
// остается сравнить заполненные мишей и рандомно массивы и система должна выдать в каких позициях значения не совпали 
//( ячейка такая то == ячейке такой то второго массива? если нет то считать ошибку?)

void InputMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(2)== 0? 'W':'B'; 
        }
           
    }
}

void PrintMatrix(char[,] matrix)
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
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице");
int column = Convert.ToInt32(Console.ReadLine());

//Миша должен заполнить свой массив (описать фото). Создам массив
char[,] OriginalPhoto = new char[row, column];

//ручками заполняю/ в целом нам все равно как в цикле мы будем итерировать. 
for (int i = 0; i < row; i++)
{   Console.WriteLine("Введите цвет пикселя для описания оригинала изображения (W - white, B - black): ");
    for (int j = 0; j < column; j++)
    {
        OriginalPhoto[i, j] = Convert.ToChar(Console.ReadLine());
    }
}

Console.WriteLine("Вывожу характеристики оригинального снимка: ");
PrintMatrix(OriginalPhoto);

Console.WriteLine("Вывожу характеристики снимка созданного программой: ");
// НОВЫЙ массив

char[,] NewPhoto = new char[row, column];
InputMatrix(NewPhoto);
PrintMatrix(NewPhoto);
int count = 0;
// начинаем сравнивать два массива. для этого используем вложенные циклы/ по сути без разницы какой будет итерироваться

   
for (int i = 0; i < OriginalPhoto.GetLength(0); i++)
{
        
    for (int j = 0; j < OriginalPhoto.GetLength(1); j++)
    {
        if(OriginalPhoto[i, j] == NewPhoto[i, j])
        {
            Console.WriteLine($" Пиксели на оригинале {OriginalPhoto[i, j]} [{i},{j}] и на фото, выданном программой {NewPhoto[i, j]} [{i},{j}] одинаковые");
            count++;
        }
        else
        {
            Console.WriteLine($" Пиксели на оригинале {OriginalPhoto[i, j]} [{i},{j}] и на фото, выданном программой {NewPhoto[i, j]} [{i},{j}] отличаются");
            
        }
            
    }
      
}
Console.WriteLine($"Совпадений: {count} ");


