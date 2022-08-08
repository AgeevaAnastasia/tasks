// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
int count = NumberOfDigits(num);
int res = SumOfDigits(num, count);
Console.WriteLine($"Сумма цифр числа {num} равна {res}");


//дальше методы, вызов которых выше ^
int NumberOfDigits(int number)
{
    int a = num;
    int i = 0;
    while (a > 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}


int SumOfDigits (int num1, int count1)
{
    int summ = 0;
    int a = num1;
    for (int i = 1; i <= count; i++)
    {
        a = a % 10;
        summ = summ + a;
        a = num1 / 10;
        num1 = a;
    }
    return summ;
}

