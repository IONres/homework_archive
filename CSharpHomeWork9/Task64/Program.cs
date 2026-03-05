/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();

Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"\nНатуральные числа от {number} до 1: \n{(FindIntNumber(number))}\n");

string FindIntNumber(double num)
{
    num = Math.Floor(num);
    if (num  <= 1) return "1";
    else return $"{num}, {FindIntNumber(num - 1)}";
}
