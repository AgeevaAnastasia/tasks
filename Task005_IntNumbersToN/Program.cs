// Напишите программу, которая принимает на входе число N, а на выходе выводит все целые числа от -N до N


Console.Clear();
Console.Write("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = -N;
while (a <= N)
{
    Console.Write($"{a} ");
    a++;
}