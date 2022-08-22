// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.Write("Введите натуральное число: ");
int numUser = Int32.Parse(Console.ReadLine());

Console.Clear();
Console.Write($"N = {numUser} -> ");
NaturalNumbers (numUser);
Console.WriteLine();

void NaturalNumbers (int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}








// Решение без рекурсии.
// Console.Clear();
// Console.Write($"N = {numUser} -> '");
// NaturalNumsFrom1ToN (numUser);
// Console.WriteLine();

// void NaturalNumsFrom1ToN(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         if (i == num) Console.Write($"{i}'");
//         else Console.Write($"{i}, ");
//     }
// }
