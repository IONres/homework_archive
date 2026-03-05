/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] array = new int[RandomSizeArray()];
array = FillArray(array);
System.Console.WriteLine($"массив: {string.Join(", ", array)}");
System.Console.WriteLine($"\nКоличество четных чисел: {CountEvenNum(array)}");

int RandomSizeArray()
{
    Random rnd = new Random();
    int length = rnd.Next(1, 7); // верхнее ограничение из-за соображений удобства проверки
    System.Console.WriteLine($"Размер массива: {length}");
    return length;
}
int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000);
    return array;
}
int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}
