// Напишите программу, которая принимает на вход число n и выдает таблицу квадратов чисел от 1 до n
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

// int a = 1;
// Console.WriteLine($"{n}:");
// while (a <= n)
// {
//     int res = a*a;
//     Console.WriteLine($"{a} -> {res}");
//     a++;
// }

Console.WriteLine("Число\tКвадрат");
for (int i = 1; i <= Math.Abs(n); i++)
{
    Console.WriteLine("{0}\t{1}", i, Math.Pow(i,2));
}


// И то же самое с помощью метода

Console.Write("Введите число:");
int n1 = Convert.ToInt32(Console.ReadLine());

WriteSquareTable(n1);


void WriteSquareTable(int n1)
{
int a = 1;
while (a <= n1)
{
Console.WriteLine($"| {a, 2} | {a * a, 2} |");
a++;
}
}