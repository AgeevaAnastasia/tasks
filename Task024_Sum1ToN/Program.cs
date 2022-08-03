// Напишите программу, которая принимает на вход число N и выдает на выход сумму чисел от 1 до N
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число");
int n = Int32.Parse(Console.ReadLine());
if (n > 0)
{
    int GetSum(int num)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum = sum + i;
        }
        return sum;
    }
    int res = GetSum(n);
    Console.WriteLine($"{n} -> {res}");
}
else Console.WriteLine("Вы ввели нерелевантное число");