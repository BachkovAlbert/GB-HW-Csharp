//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

Console.Clear();

int SumNums(int M, int N)
{
    if(M == N) return M;
    if(M > N) return M + (SumNums(M-1,N)); 
    return N + (SumNums(M,N-1));
}

Console.Write("Input integer number(M): ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number(N): ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"The sum of the numbers in the gap is {SumNums(M, N)}");

*/

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

/*
Console.Clear();

int NumberOfDigits(int Num)
{
    if(Num == 0) return 0;
    return  1 + NumberOfDigits(Num/10);
}

Console.Write("Input integer number(Num): ");
int Num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{NumberOfDigits(Num)}");
*/



