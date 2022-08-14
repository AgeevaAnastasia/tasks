// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.Write("Сколько чисел последовательности Фибоначчи вывести на экран? ");
int n = Int32.Parse(Console.ReadLine());

Console.Write($"{n} -> 0 1 ");
Fibonacci(n);
Console.WriteLine();

void Fibonacci(int num)
{
    int[] fib = new int[n];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
        Console.Write(fib[i]+ " ");
    }
}