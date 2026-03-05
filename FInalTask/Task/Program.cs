/* Задача: Написать программу, которая из имеющегося массива строк формирует новый 
 массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Clear();

string[] arr = { "122", "1567", "-22", "computer science", "ff", "22" };
PrintNewArr(ElementSelection(arr));

string[] ElementSelection(string[] arr)
{
    string[] newArr = Array.Empty<string>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            //sizeNewArr = sizeNewArr + 1;

            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[^1] = arr[i];
        }
    }
    return newArr;
}

void PrintNewArr(string[] arrForPrint)
{
    if (arrForPrint.Length > 0)

        Console.WriteLine("[{0}]", string.Join(", ", arrForPrint));

    else
        System.Console.WriteLine("нет элементов, соответсвущих условию");
}