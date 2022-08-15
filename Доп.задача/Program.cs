/*
Задана целочисленная квадратная матрица размером N x N. Требуется транспонировать ее относительно главной диагонали.
*/
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int [n, m];
int [,] matrix2 = new int [n, m];
Console.WriteLine("Вводная матрица: ");
for (int i = 0; i < n; i++)//строка
{
    for (int j = 0; j < m; j++)//столбцы
    {
        matrix[i,j] = new Random().Next(0, 100);
        Console.Write(matrix[i, j] + "\t");// /t - табуляция
    }
    Console.WriteLine();
}
Console.WriteLine();
//транспонирование-замена строк на столбцы(если кратко)
Console.WriteLine("Транспонированная матрица: ");
for (int i = 0; i < n ; i++)
{
    for (int j = 0; j < m; j ++)
    {
        matrix2[i,j] = matrix[j,i];//смена мест
        Console.Write(matrix2[i, j] + "\t");// /t - табуляция
    }
    Console.WriteLine();
}
Console.WriteLine();