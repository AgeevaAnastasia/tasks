// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите целое трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int res;
if (a > 99 && a < 1000)
{
    res = (a % 100) / 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}