// See https://aka.ms/new-console-template for more information
Console.Clear   ();

void FillArray(int[] collection) // woid (метод) не возвращает значение. Не используется return
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght) 
    {
        collection[index] = new Random ().Next (1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col [position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position =-1;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10]; // создай новый массив, в котором будет 10 элементов (по умолчанию заполнен 0)

FillArray (array); // заполнить массив
PrintArray (array); //распечатать массив
Console.WriteLine ();

int pos = IndexOf (array, 444);
Console.WriteLine (pos);