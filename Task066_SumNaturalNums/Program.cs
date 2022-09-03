// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите натуральное число M: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int nUser = Int32.Parse(Console.ReadLine());

Console.Clear();
Console.Write($"M = {mUser}, N = {nUser} -> ");
if (mUser < nUser) Console.WriteLine(GetSumMtoN(mUser, nUser));
else Console.WriteLine(GetSumNtoM(mUser, nUser));


int GetSumMtoN(int m, int n)
{
    int sum = m;
    if (n > m)
        sum += GetSumMtoN(m + 1, n);
    return sum;
}

int GetSumNtoM(int m, int n)
{
    int sum = n;
    if (n < m)
        sum += GetSumNtoM(m, n + 1);
    return sum;
}