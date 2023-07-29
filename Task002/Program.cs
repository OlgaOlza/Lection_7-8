﻿// Собрать строку с числами от а до b, a >= и
// Рекурсия


string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));