// Напишите программу, которая принимает на входе трёхзначное число и на выходе показывает его последнюю цифру

Console.Clear();
Console.Write("Введите целое трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000)
{
    a = a % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}