// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int numUser = InputNumbers("Введите число: ");


Console.Write($"{numUser} -> "); 
Console.Write(GetSumOfDigits(numUser));
Console.WriteLine();

int GetSumOfDigits(int num)
{
    int sum = num % 10;
    if (sum >= 1)
        sum += GetSumOfDigits(num / 10);

    return sum;
}


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
