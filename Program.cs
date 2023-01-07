/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string Num(int a, int b)
{
    string result = string.Empty;
    for (int i=a;i>=b;i--)
    {
        result += $"{i}";
    }
    return result;
}

string numrec(int a,int b)
{
    if (a <= b) return numrec(a+1,b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(Num (1,8));
Console.WriteLine(numrec (1,8));