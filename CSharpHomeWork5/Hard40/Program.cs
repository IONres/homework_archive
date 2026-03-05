/*
задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
 Определить , является ли это сторонами треугольника.+
  Если да, то вывести всю информацию по нему :
 -площадь+
 -периметр 
 -значения углов треугольника в градусах
 - прямоугольный, равнобедренный, равносторонний?
*/
Console.Clear();

int[] array = ReadNum(3);
if (IsTriangle(array) == false)
    System.Console.WriteLine("\nэто не треугольник");
else
{
    System.Console.WriteLine($"\nПериметр треугольника = {Perimeter(array)}");
    System.Console.WriteLine($"Площадь треугольника = {AreaTriangle(array)}");
    double[] cornersq = Corners(array);
    System.Console.WriteLine($"тип треугольника - {TypeTriangleSide(array)}, {TypeTriangleCorner(cornersq)} ");
}

int[] ReadNum(int countNum)
{
    Console.WriteLine($"Введите {countNum} целых, положительных числа(ел)");
    int[] array = new int[countNum];
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"Сторона {i + 1} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    return array;
}
bool IsTriangle(int[] array)
{
    bool result = false;
    if (array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[2] + array[1] > array[0])
        result = true;

    return result;
}
double Perimeter(int[] array)
{
    int perimeter = array[0] + array[1] + array[2];
    return perimeter;
}
double AreaTriangle(int[] array)
{
    int halfPerimeter = (array[0] + array[1] + array[2]) / 2;
    double Area = Math.Round((Math.Sqrt(halfPerimeter * (halfPerimeter - array[0]) * (halfPerimeter - array[1]) * (halfPerimeter - array[2]))), 2, MidpointRounding.AwayFromZero);
    return Area;
}
double[] Corners(int[] array)
{
    double acosCornerA = Math.Acos((Math.Pow(array[0], 2) + Math.Pow(array[1], 2) - Math.Pow(array[2], 2)) / (2 * array[0] * array[1]));
    double cornerA = Math.Round(acosCornerA * (180 / Math.PI), 2, MidpointRounding.AwayFromZero);

    double acosCornerB = Math.Acos((Math.Pow(array[0], 2) + Math.Pow(array[2], 2) - Math.Pow(array[1], 2)) / (2 * array[0] * array[2]));
    double cornerB = Math.Round(acosCornerB * (180 / Math.PI), 2, MidpointRounding.AwayFromZero);

    double acosCornerC = Math.Acos((Math.Pow(array[1], 2) + Math.Pow(array[2], 2) - Math.Pow(array[0], 2)) / (2 * array[1] * array[2]));
    double cornerC = Math.Round(acosCornerC * (180 / Math.PI), 2, MidpointRounding.AwayFromZero);

    double[] result = new double[3] { cornerA, cornerB, cornerC };
    System.Console.Write($"Углы: {string.Join("°; ", result)}");
    System.Console.WriteLine("°.");
    return result;

}
string TypeTriangleSide(int[] array)
{
    string result;
    if (array[0] == array[1] && array[0] == array[2])
        result = "равносторонний";
    else if (array[0] == array[1] || array[0] == array[2] || array[1] == array[2])
        result = "равнобедренный";
    else
        result = "разносторонний";
    return result;
}
string TypeTriangleCorner(double[] array)
{
    string result;
    if (array[0] < 90 && array[1] < 90 && array[2] < 90)
        result = "остроугольный";
    else if (array[0] > 90 | array[1] > 90 | array[2] > 90)
        result = "тупоугольный";
    else
        result = "прямоугольный";

    return result;
}
