//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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

int[,] SortingElementsInAscending(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, k] < array[i, j])
                {
                    int SpiralNum = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = SpiralNum;
                }
            }
        }
    }
    return array;    
}

Console.Write("input the number of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomTwoDemArray(lines, columns, min, max);
ShowRandomTwoDemArray(array);

Console.WriteLine();

ShowRandomTwoDemArray(SortingElementsInAscending(array));

*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

Console.Clear();

int[,] CreateRandomTwoDemArray(int LinesColumns, int min, int max)
{
    int[,] newMatrix = new int[LinesColumns,LinesColumns];

    for(int i = 0; i < LinesColumns; i++)
        for(int j = 0; j < LinesColumns; j++)
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

int TheRowWithTheSmallestSumOfElements(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(i == 0) minSum = sum;
        else if(sum < minSum) 
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}

Console.Write("input the number of rows/columns: ");
int LinesColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomTwoDemArray(LinesColumns, min, max);
Console.WriteLine();
ShowRandomTwoDemArray(array);
Console.WriteLine();
Console.WriteLine($"{TheRowWithTheSmallestSumOfElements(array)+1} строка -> с наименьшей суммой элементов");
Console.WriteLine();

*/

//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
/*
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

/*

Console.Clear();

int size = 4, SpiralNum = 1, i = 0, j = 0;
int[,] spiral = new int[size, size];

while (SpiralNum <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[i, j] = SpiralNum; SpiralNum++;
  if (i <= j + 1 && i + j < spiral.GetLength(1) - 1) j++;
  else if (i < j && i + j >= spiral.GetLength(0) - 1) i++;
  else if (i >= j && i + j > spiral.GetLength(1) - 1) j--;
  else i--;
}

void ShowSpiral(int[,] array)
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
Console.WriteLine();
ShowSpiral(spiral);

*/