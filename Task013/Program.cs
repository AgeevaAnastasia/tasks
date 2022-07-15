// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int res;

if (a < 99)
{
    Console.WriteLine("Третьей цифры нет");
}

else 
{   while (a > 1000)
    {
        a = a/10;
    }
    res = a % 10;

    Console.WriteLine($"Третья цифра числа это {res}");
}
