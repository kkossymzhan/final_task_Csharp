/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
System.Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

System.Console.WriteLine($"The calculation of the Ackerman function for {m} and {n} is equal to {Ackerman(m,n)}");
