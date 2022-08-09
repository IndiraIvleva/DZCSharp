//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

using static System.Console;
Clear();

WriteLine("Введите число:");
double a = Convert.ToDouble(ReadLine());

if (a % 2 == 0) 
{
    Write("Число ");
    Write(a);
    Write(" является четным");
} 
else
{
    Write("Число ");
    Write(a);
    Write(" является нечетным");
}