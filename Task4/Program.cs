//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using static System.Console;
Clear();

WriteLine("Введите число N:");
int n = Convert.ToInt32(ReadLine());
int i = 1;
WriteLine($"Ряд четных чисел от 1 до {n}");
while (i <= n)
{
    if (i % 2 == 0)
    {
        
        Write(i);
        Write(", ");
        i++;
    }

    else
    {
        i++;
    }
}