// METHOD 1. Printing counters and details in loops and other

Console.WriteLine("Вывожу количество ягод на каждом кусте: \n");
Console.WriteLine("index" + " No.куста"  + " ягод");

for (int j = 0; j < numberShrubs; j++)
{
    Console.WriteLine (j + "\t"+ (j+1) + "\t" + CountBerrys[j]);
}
Console.WriteLine();

for (i = 0; i < numberShrubs-2; i++)
{
    CurSum = CountBerrys[i] + CountBerrys[i+1] + CountBerrys[i+2]; 
    Console.WriteLine("Iterat. " + "CurSum");
    Console.WriteLine (i + " \t " + CurSum);  
    if (CurSum > MaxSum) 
    {
      MaxSum = CurSum;  
      Console.WriteLine ($"Максимальная в этом сравнении {MaxSum}"); 
      Console.WriteLine ($"Текущая сумма  {CurSum}"); 
    }  
}
// METHOD 2. ARRAYS length print
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
print_array(CountBerrys);
// ------------------------------------------------------
//Method 3: ask my ducky for help+))



