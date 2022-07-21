// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"| Число | Куб числа |");
Console.WriteLine($"|-------|-----------|");
WriteCubeTable(n);


void WriteCubeTable(int n1)
{
    for (int a = 1; a <= n1; a++)
    {
        Console.WriteLine($"| {a, 5} | {a * a * a, 9} |");
        Console.WriteLine($"|-------|-----------|");
    }
}
