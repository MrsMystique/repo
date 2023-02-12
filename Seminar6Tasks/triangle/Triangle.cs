/*Площадь треугольника
приму на ввод координаты (x1,y1), (x2,y2) и (x3,y3)  не больше 106 каждая

ведите точное значение площади заданного треугольника.*/
Console.Clear();
Console.WriteLine("Введите первую координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите первую координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите первую координату x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
//считаю расстояние между x1,y1 и x2,y2
double Side1Length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(Math.Round(Side1Length, 2));
//считаю расстояние между x1,y1 и x3,y3
double Side2Length = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y3 - y1, 2));
Console.WriteLine(Math.Round(Side2Length, 2));
//считаю расстояние между x2,y2 и x3,y3
double Side3Length = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y3 - y2, 2));
Console.WriteLine(Math.Round(Side3Length, 2));
// Расчитываю полупериметр
double PoluPerimetr = Math.Round(Side1Length + Side2Length + Side3Length) / 2;
Console.WriteLine($"Полу-периметр заданного треугольника = {PoluPerimetr}");
// Расчитываю площадь применяя функции возврата абсолютного положительного числа, так как нельзя взять корень квадратный от отрицательного числа
// беру корень квадратный из положительного значения выражения
// Округляю
double S = Math.Round(Math.Sqrt(Math.Abs(PoluPerimetr * (PoluPerimetr - Side1Length) * (PoluPerimetr - Side2Length) * (PoluPerimetr - Side3Length))), 2);
Console.WriteLine($"Площадь заданного треугольника = {S}");