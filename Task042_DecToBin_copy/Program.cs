// Напишите программу, которая преобразовывает десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.Write("Введите число в десятичной системе: ");
int num = Int32.Parse(Console.ReadLine());

Console.Write($"{num} -> ");
Console.WriteLine(ConvertToBin(num));

int ConvertToBin(int num1)
{
    int p = 1;
    int res = 0;
    while (num > 0)
    {
        res = res + num % 2 * p;
        p = p * 10;
        num = num / 2;
    }
    return res;
}




//==========================================================================================
// Решение Юрия

// Console.Clear();

// int num = GetUserInput();

// System.Console.WriteLine(ConvertToBinary(num));

// string ConvertToBinary(int num)
// {
// string binary = string.Empty;
// while (num >= 1)
// {
// binary+= num % 2;
// num /= 2;
// }
// var item = binary.Reverse();
// binary = "";
// foreach(var i in item)
// {
// binary += i.ToString();
// }

// return binary;

// }

// int GetUserInput()
// {
// Console.Write("Введите число: ");
// return Convert.ToInt32(Console.ReadLine());
// }





//==========================================================================================
// Решение Александры


// Console.Clear();

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string Result(int num1)
// {
//     string res = "";
//     while (num1 > 0)
//     {
//         res += num1 % 2;
//         num1 /= 2;
//     }
//     return res;
// }

// void PrintString(string result)
// {
//     for (int i = result.Length - 1; i >= 0; i--)
//     {
//         Console.Write(result[i]);
//     }
// }

// string res = Result(num);
// PrintString(res);



