// Напишите программу, которая принимает на вход число n и выдает произведение чисел от 1 до n
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int n = Int32.Parse(Console.ReadLine());

int GetProduct(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;   
    }
    return sum;
}

int res = GetProduct(n);
Console.WriteLine($"Произведение чисел от 1 до {n} равно {res}");
