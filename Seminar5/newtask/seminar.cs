Console.Clear();
/* ЗАДАЧА существует ли треугольник с такими сторонами
Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Существует");
}

else
{
    Console.WriteLine("НЕ Существует");
}

// конверт десятичной в двоичную
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
  result = Convert.ToString(n % 2) + result;
  n = n / 2;
}
Console.WriteLine(result);

   
// FIBONACCI  
Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());
int numberFib = 1;
Console.Write("{0} ", numberFib);
int numberFib2 = 1;
Console.Write("{0} ", numberFib2);
int sum = 0;
while (number >= sum)
            {
                sum = numberFib + numberFib2;
                
                    Console.Write("{0} ", sum);
                    
                        numberFib = numberFib2;
                        numberFib2 = sum;                
                }

while (number >= sum)
            {
                sum = numberFib + numberFib2;
                
                    Console.Write("{0} ", sum);
                    
                        numberFib = numberFib2;
                        numberFib2 = sum;                
                }
   // var2 fibo             
 Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
  Console.Write($"{a0} ");
  x = a0 + a1;
  a0 = a1;
  a1 = x;
}           
//array copy a to b
Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];
for (int i = 0; i < b.Length; i++)
  b[i] = a[i];
b[0] = b[0] + 5;
Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b));*/


