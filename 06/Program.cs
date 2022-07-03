// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

Console.Clear();

Console.Write("Input number of digits(M): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[M];

void InputNumbers(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Input number {i+1} : ");
    ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int FindNumbersMoreZero(int[] ArrayNumbers)
{
  int count = 0;
  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if(ArrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Numbers > 0 -> {FindNumbersMoreZero(ArrayNumbers)} ");

*/

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*

Console.Clear();

Console.Write("Input number of digits(Size): ");
int Size = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[Size];

void InputNumbers(int Size)
{
for (int i = 0; i < Size; i++)
    {
        Console.Write($"Input number {i+1} : ");
        ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int[] CopyArray(int[] array)
{
  int[] NewArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    NewArray[i] = array[i];
  }
  return NewArray;
}

InputNumbers(Size);
int[] CopArray = CopyArray(ArrayNumbers);

Console.WriteLine("Copy your array:");
for(int i = 0; i < CopArray.Length; i++)
{
  Console.WriteLine(CopArray[i] + " ");
}

*/