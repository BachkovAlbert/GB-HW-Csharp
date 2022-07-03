//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

Console.Clear();

double[,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
    double[,] newMatrix = new double[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            newMatrix[i,j] = new  Random().NextDouble() * (max - min) + min;
    
    return newMatrix;
}

void ShowRandomTwoDemArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 1) + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("input number of lines: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomTwoDemArray(m, n, min, max);
ShowRandomTwoDemArray(array);

*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

Console.Clear();

int[,] CreateRandomTwoDemArray(int lines, int columns, int min, int max)
{
    int[,] newMatrix = new int[lines,columns];

    for(int i = 0; i < lines; i++)
        for(int j = 0; j < columns; j++)
            newMatrix[i,j] = new Random().Next(min, max + 1);
    
    return newMatrix;
}

void ShowRandomTwoDemArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("input the number of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("input the line number: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("input the column number: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomTwoDemArray(lines, columns, min, max);
Console.WriteLine();

if(line > array.GetLength(0) || column > array.GetLength(1))
    Console.WriteLine("такого числа нет");
else Console.WriteLine($"The value on line {line} and column {column} is {array[line-1,column-1]}");

Console.WriteLine();
ShowRandomTwoDemArray(array);
Console.WriteLine();

*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

Console.Clear();

int[,] CreateRandomTwoDemArray(int lines, int columns, int min, int max)
{
    int[,] newMatrix = new int[lines,columns];

    for(int i = 0; i < lines; i++)
        for(int j = 0; j < columns; j++)
            newMatrix[i,j] = new Random().Next(min, max + 1);
    
    return newMatrix;
}

void ShowRandomTwoDemArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] AverageOfColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double count = 0, sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
            count++;
        }
        result[i] = Math.Round(sum / count, 1);
        
    }
    return result;
}

Console.Write("input the number of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] array = CreateRandomTwoDemArray(lines, columns, min, max);
ShowRandomTwoDemArray(array);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
double[] result = AverageOfColumns(array);

for (int i = 0; i < result.Length ; i++)
    Console.Write($"{result[i]}; "); 

*/
