// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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

Console.Write($"Input a three-digit number: ");
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

