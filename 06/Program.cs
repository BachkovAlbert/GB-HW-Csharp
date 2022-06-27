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

///*

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

for (int i = 0; i < ArrayNumbers.Length; i++)
    {
        Console.Write(ArrayNumbers[i] + ", ");
    }
}

InputNumbers(M);


//*/