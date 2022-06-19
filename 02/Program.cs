// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

Console.Clear();

int Function(int Num)
{
    if(Num >= 100 && Num <= 999)
    {
        int a = Num % 100;
        int b = a / 10;

        int result = b;
        return result;
    }
    else
    {
        return -1;
    }
}

Console.Write($"Input a integer three-digit number: ");
int Num = Convert.ToInt32(Console.ReadLine());

int result = Function(Num);

if(result == -1)
{
    Console.WriteLine("Your number is not a third-digit");
}
else
{
    Console.WriteLine($"Second digit is {result}");
}

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

Console.Clear();

int Function(int Num)
{
    if(Num > 100 && Num > 10)
    {
        return Num;
    }
    else
    {
        return -1; 
    }
}

Console.Write($"Input a integer positive number: ");
int Num = Convert.ToInt32(Console.ReadLine());
int result = Function(Num);
string NumT = Convert.ToString(result);

if(result == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    Console.WriteLine($"Third digit is {NumT[2]}");
}

*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

Console.Clear();

int Function(int Num)
{
    if (Num == 6 || Num == 7)
    {
        return -1;
    }
    else if (Num < 1 || Num > 7)
    {
        return -2;
    }
    else
    {
        return -3;
    }
}

Console.Write($"Input a integer positive number(1-7): ");
int Num = Convert.ToInt32(Console.ReadLine());
int result = Function(Num);

if(result == -1)
{
    Console.WriteLine("Выходной день - ДА");
}
if(result == -2)
{
    Console.WriteLine("Такого дня недели нету");
}
if(result == -3)
{
    Console.WriteLine("Выходной день - НЕТ");
}

*/