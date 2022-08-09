// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
using static System.Console;
Clear();
WriteLine("Введите число А");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число В");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите число C");
int c = Convert.ToInt32(ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число = ");
Console.WriteLine(max);