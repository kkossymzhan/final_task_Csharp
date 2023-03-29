/* 
Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

/* 
int SumFromMtoNElements (int M, int N)
{
    int sum = 0;
    for (int i = M; i<= N; i++)
        sum +=i;
    return sum; 
}
*/

int SumFromMtoNElements (int M, int N)
{
    if (M == N)
        return N;
    else 
        return N + SumFromMtoNElements(M, N-1);
}
System.Console.WriteLine($"The sum of numbers between {M} and {N} is {SumFromMtoNElements(M,N)}");