// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

Console.Clear();

Console.Write("Input integer positive five-digit number: ");
int Num0 = Convert.ToInt32(Console.ReadLine());                 
string Num = Convert.ToString(Num0);

void Function(string Num)
{
  if (Num[0] == Num[4] && Num[1] == Num[3])   Console.WriteLine($"{Num} -> да");
  else Console.WriteLine($"{Num} -> нет");
}

if (Num.Length == 5) Function(Num);
else Console.WriteLine($"It is not a five-digit number");

*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

Console.Clear();

double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}
Console.Write("x1 = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A ({xA},{yA},{zA}); B ({xB},{yB},{zB}), -> {FindLenght(xA, yA, zA, xB, yB, zB)}");

*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125