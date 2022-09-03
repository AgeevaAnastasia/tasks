// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите положительное число M: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int nUser = Int32.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"M = {mUser}, N = {nUser} -> A(m,n) = {Akkerman(mUser, nUser)}");


int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman (m - 1, 1);
    else return Akkerman (m - 1, Akkerman (m, n - 1));
}