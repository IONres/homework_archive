// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Clear();

Console.WriteLine("Введите три числа.Если число дробное, разделяйте целую и дробную часть запятой \",\". ");

Console.Write(" \n\tчисло 1 = ");
double number1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("\tчисло 2 = ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("\tчисло 3 = ");
double number3 = Convert.ToDouble(Console.ReadLine());


if (number1 > number2 && number1 > number3  )
    Console.WriteLine($"\nМаксимальное число = {number1}");
else if (number2>number3) 
    Console.WriteLine($"\nМаксимальное число = {number2}");
else 
    Console.WriteLine($"\nМаксимальное число = {number3}");

 

