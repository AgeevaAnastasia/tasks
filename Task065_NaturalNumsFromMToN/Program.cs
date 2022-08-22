// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Введите натуральное число M: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int nUser = Int32.Parse(Console.ReadLine());

// Console.Clear();
// if (mUser < nUser)
// {
//     Console.Write($"M = {mUser}, N = {nUser} -> ");
//     NaturalNumbersMtoN(mUser, nUser);
// }
// else
// {
//     Console.Write($"N = {nUser}, M = {mUser} -> ");
//     NaturalNumbersNtoM (mUser, nUser);
// }
// Console.WriteLine();

// // void NaturalNumbersMtoN (int m, int n)
// // {
// //     if (n < m) return;
// //     NaturalNumbersMtoN(m, n - 1);
// //     Console.Write($"{n} ");
// // }

// void NaturalNumbersMtoN(int m, int n)
// {
//     if (n < m) return;
//     Console.Write($"{m} ");
//     NaturalNumbersMtoN(++m, n);
// }

// void NaturalNumbersNtoM(int m, int n)
// {
//     if (n > m) return;
//     Console.Write($"{n} ");
//     NaturalNumbersNtoM(m, ++n);
// }

GetNaturalNums(mUser, nUser);
Console.WriteLine();

void GetNaturalNums (int m, int n)
{
	if (n == m)
    {
        Console.Write($"{m} ");
        return;
    }

    if (m > n)
    {
        Console.Write($"{m} ");
        GetNaturalNums(m - 1, n);
    }

    else
    {
        GetNaturalNums(m, n - 1);
        Console.Write($"{n} ");
    }

}
