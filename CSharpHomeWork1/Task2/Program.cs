// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 

Console.Clear   ();

Console.WriteLine ("Введите два числа. Если число дробное, разделяйте целую и дробную часть запятой (,). ");

Console.Write ("первое число = ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("второе число = ");
double number2 = Convert.ToDouble(Console.ReadLine());


if (number1 > number2) 
{
    Console.WriteLine($"{number1} > {number2}");
    }
else if (number1 < number2)
    Console.WriteLine ($"{number1} < {number2}");
else 
    Console.WriteLine ($"{number1} = {number2} ");
