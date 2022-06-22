// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

Console.Clear();

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
        Console.Write(newArray[i] + " ");
    }
    
    return newArray;
}

int EvenNumbersInArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 > 0) 
        count++;
    }

    return count = array.Length - count;
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);

Console.Write($" -> {EvenNumbersInArray(myArray)} (even numbers)");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

Console.Clear();
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    
    return newArray;
}

int SumOddPositionIndexOfArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0) 
        sum += array[i];
        
    }
    return sum;
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input start of range (from): ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input end of range (to): ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.Write($" -> {SumOddPositionIndexOfArray(myArray)} (sum of elements in odd positions)");

*/

//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Вариант 1
/*

Console.Clear();

double[] CreateRandomArray(int size, int max, int min)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() * (min + max);
        Console.Write(newArray[i] + " ");
    }
    
    return newArray;
}

double DifferenceMaxAndMin(double[] array)
{
    double r = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    return r = max - min;

}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input start of range (from): ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input end of range (to): ");
int max = Convert.ToInt32(Console.ReadLine());


double[] myArray = CreateRandomArray(size, max, min);

Console.Write($" -> {DifferenceMaxAndMin(myArray)} (difference between maximum and minimum array elements)");

*/

//Вариант 2

/*

Console.Clear();

int[] Massive(int size)   
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write("введите цифру массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
    }

    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    return array;
}

int DifferenceMaxAndMin(int[] array)
{
    int r = 0;
    int min = array[0];
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    return r = max - min;

}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = Massive(size);        

Console.Write($" -> {DifferenceMaxAndMin(myArray)} (difference between maximum and minimum array elements)");

*/