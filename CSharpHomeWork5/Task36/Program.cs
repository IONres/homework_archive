/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
int[] array = new int[RandomSizeArray()];
array = FillArray(array);
System.Console.WriteLine($"Массив: {string.Join(", ", array)}");
SumOddNum(array);

int RandomSizeArray()
{
    Random rnd = new Random();
    int length = rnd.Next(1, 10);
    System.Console.WriteLine($"Размер массива: {length}");
    return length;
}
int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-2147483648, 2147483647);
    return array;
}
void SumOddNum(int[] array)
{
    int count = 0;
    int sum = 0;
    int i = 1;
    if (array.Length == 1)
        Console.WriteLine("\nВ массиве нет нечетных позиций");
    else
    {
        while (i < array.Length)
        {
            sum += array[i];
            i += 2;
        }
        System.Console.WriteLine($"\nСумма элементов нечетных позиций : {sum}");
    }
}
