// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//Вариант 1.
/*

Console.Clear();

double Function(double A, double B)
{
    double R = A;
    double i = 1;
    if(i < B)
    {
        while(i < B)
        {
            R = R * A;
            i++;
        }
        return R;
    }
    else 
    {
        i = - 1;
        while(i > B)
        {
            R = R * A;
            i--;
        }
        return R = 1 / R;
    }
}
Console.Write("Input integer first number: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Input integer second number: ");
double B = Convert.ToDouble(Console.ReadLine());

Console.Write($"{A}^{B} -> {Function(A,B)}");

*/

//Вариант 2.
/*

Console.Clear();

void Function(double A, double B)
{
    double result = Math.Pow(A,B);
    Console.Write($"({A}^{B}) -> {result}");
}
 
Console.Write("Input first number: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number: ");
double B = Convert.ToDouble(Console.ReadLine());

Function(A,B);

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]

/*

Console.Clear();

int Size = 8;
int [] array = new int[Size];

for (int i = 0; i < array.Length; i++) 
 {
    Console.Write("введите цифру ");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
 }

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}

*/   