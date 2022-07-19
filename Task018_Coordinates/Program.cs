// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x, y)

Console.Write("Введите номер четверти на координатной плоскости (1, 2, 3 или 4): ");
string num = Console.ReadLine();

string Coordinates(string numQ)
{
    if (numQ == "1") return "x положительный, y положительный";
    if (numQ == "2") return "x отрицательный, y положительный";
    if (numQ == "3") return "x отрицательный, y отрицательный";
    if (numQ == "4") return "x положительный, y отрицательный";
    return "Введен некорректный номер четверти";
}

string result = Coordinates(num);
Console.WriteLine(result);