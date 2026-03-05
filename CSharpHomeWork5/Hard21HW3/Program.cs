/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
*/
Console.Clear();

Console.Write("Введите размерность пространства(натуральное число): ");
int spaceDimension = Convert.ToInt32(Console.ReadLine());
if (spaceDimension <= 0)
    System.Console.WriteLine("\nВведенное значение некорректно. Пожалуйста, введите целое число , больше нуля.");
else
{
    Console.WriteLine("\nВведите кординаты точки А");
    double[] PointA = new double[spaceDimension];
    PointA = coordinate(spaceDimension);

    Console.WriteLine("\nВведите координаты точки B");
    double[] PointB = new double[spaceDimension];
    PointB = coordinate(spaceDimension);

    Console.WriteLine($"\nРасстояние между точками = {distance(PointA, PointB):F2}");
}
double[] coordinate(int n)
{

    double[] a = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{i + 1} Кордината точки   = ");
        a[i] = Convert.ToDouble(Console.ReadLine());

    }
    return a;
}
double distance(double[] pointA, double[] pointB)
{
    double result = 0;
    for (int i = 0; i < pointA.Length; i++)
        result += Math.Pow((pointB[i] - pointA[i]), 2);
    return Math.Sqrt(result);
}
