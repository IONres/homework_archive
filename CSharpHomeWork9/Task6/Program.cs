/*Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Введите число 1: ");
double numberStart = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число 2: ");
double numberEnd = Convert.ToDouble(Console.ReadLine());
RevalueNegativeNum(ref numberStart, ref numberEnd);
PrintSumInt(numberStart, numberEnd);

void RevalueNegativeNum(ref double start, ref double end)
{
    if (start <= 0 && end <= 0) { start = 0; end = 0; }
    else if (start <= 0 && end >= 0) start = 1;
    else if (start >= 0 && end <= 0) end = 1;
}
double SumIsEndMax(double start, double end)
{

    if (start < end)
    {
        start = Math.Ceiling(start);
        end = Math.Floor(end);

        return FindSumInt(start, end);
    }
    else
    {
        start = Math.Floor(start);
        end = Math.Ceiling(end);

        return FindSumInt(end, start);
    }
}
double FindSumInt(double start, double end)
{
    if (start == end) return end;
    else return start + FindSumInt(start + 1, end);

}
void PrintSumInt(double start, double end)
{
    if (numberStart == 0 && numberEnd == 0)
        System.Console.WriteLine("в заданном диапазоне нет целых чисел");
    else
        System.Console.WriteLine($" \nСумма целых чисел в заданном диапазоне : {(SumIsEndMax(numberStart, numberEnd))}\n");
}
