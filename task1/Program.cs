/*
Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"     
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
System.Console.WriteLine("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1; 

if (n < 1)
{
    Console.WriteLine("The number should be more than zero");
}

int NumbersUntilN(int n, int m)
{
    if (n == m)
        return m;
    else
        Console.Write($"{NumbersUntilN(n, m + 1)}, ");
    return m;
}

Console.WriteLine(NumbersUntilN(n, m));






