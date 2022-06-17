/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Clear(); 

int a, b, max;

Console.Write("Input first integer Number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer Number: ");
b = Convert.ToInt32(Console.ReadLine());

if(a == b)
{
    Console.Write("First Number = Second Number");
}
if(a > b)
{
    max = a;
    Console.Write("Max = " + max + " (first Number)");
}
if(b > a)
{
    max = b;
    Console.Write("Max = " + max + " (second Number)");
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear(); 

int Num1, Num2, Num3, Max;

Console.Write("Input first integer Number: ");
Num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer Number: ");
Num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer Number: ");
Num3 = Convert.ToInt32(Console.ReadLine());
Max = Num1;
if(Num1 > Max) Max = Num1;
if(Num2 > Max) Max = Num2;
if(Num3 > Max) Max = Num3;
Console.Write("Max = " + Max);

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

