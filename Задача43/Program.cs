/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Задача 43");
Console.Write("Напишите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
/*нахожу X:
k1*x + b1 = k2*x + b2 => k1*x - k2*x = -b1+b2 => x(k1-k2)=-b1+b2 => x = (-b1 + b2)/(k1 - k2) => x = - (b1 -b2) / (k1 - k2)=>(b2-b1)/(k1-k2)
*/
double x = (b2-b1)/(k1-k2);
double y = k1 * x - b1;
//интерполяция строки
Console.WriteLine ($"Пересечение в точке: ({x};{y})");//***ссылки для себя https://metanit.com/sharp/tutorial/7.5.php ; https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/interpolated***

