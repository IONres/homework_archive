/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

double[] array = new double[RandomSizeArray()];
array = FillArray(array);
System.Console.WriteLine($"Массив: {string.Join("; ", array)}");
System.Console.WriteLine($"\nmax-min= {DiffMaxMin(array)} ");

int RandomSizeArray()
{
    Random rnd = new Random();
    int length = rnd.Next(1, 10);
    System.Console.WriteLine($"Размер массива: {length}");
    return length;
}
double GetRandomNumber(double minimum, double maximum)
{
    Random random = new Random();
    return Math.Round((random.NextDouble() * (maximum - minimum) + minimum), 2);
}
double[] FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = GetRandomNumber(-10, 11);
    return array;
}
double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    return Math.Round(max - min, 2, MidpointRounding.AwayFromZero);
}