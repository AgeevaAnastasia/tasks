// Напишите программу, которая преобразовывает десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.Write("Введите число в десятичной системе: ");
string user = Console.ReadLine();
int num = Int32.Parse(user);
Console.Write($"{num} -> ");
Console.WriteLine(ConvertToBin(num));

int ConvertToBin(int num1)
{
    int p = 1;
    int res = 0;
    while (num > 0)
    {
        res = res + num % 2 * p;
        p = p * 10;
        num = num / 2;
    }
    return res;
}




//==========================================================================================
// Решение через рекурсию

void ToBin (int n)
{
    if (n == 0) return;
    ToBin (n / 2);
    Console.Write(n % 2);
}

ToBin(num);
Console.WriteLine();