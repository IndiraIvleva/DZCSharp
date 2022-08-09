//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();
WriteLine("Введите число А");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число В");
int b = Convert.ToInt32(ReadLine());
if (a > b)
{
Write("Максимальное число ");
WriteLine(a);
Write("Минимальное число ");
WriteLine(b);
}
else 
{
Write("Максимальное число ");
WriteLine(b);
Write("Минимальное число ");
WriteLine(a);
}