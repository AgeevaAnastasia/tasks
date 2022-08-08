// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int a = Int32.Parse(Console.ReadLine());
Console.Write($"Введите степень, в которую нужно возвести число {a}: ");
int b = Int32.Parse(Console.ReadLine());

int NumberDegree (int num, int degree)
{
    int sum = 1;
    for (int i = 1; i <= b; i++)
    {
        sum = sum * a;
    }
    return sum;
}

int res = NumberDegree(a, b);

Console.WriteLine($"{a} в степени {b} равно {res}");
