// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Введите натуральное число M (меньшее): ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите натуральное число N (большее): ");
int nUser = Int32.Parse(Console.ReadLine());

Console.Clear();
Console.Write($"M = {mUser}, N = {nUser} -> ");
NaturalNumbersMtoN (mUser, nUser);
Console.WriteLine();

void NaturalNumbersMtoN (int m, int n)
{
    if (n == m - 1) return;
    NaturalNumbersMtoN(m, n - 1);
    Console.Write($"{n} ");
}