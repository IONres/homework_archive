//Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// (без использования строк)

//Вариант 2

Console.Clear();

Console.WriteLine("Введите число.Если число дробное, разделяйте целую и дробную часть запятой \",\". ");
Console.Write ("\nЧисло: ");

decimal number = Convert.ToDecimal (Console.ReadLine ());
number = Math.Abs(number);  
int digits = 0;

if (number < 1) 
number++; 

 while (number != Math.Floor(number))
 number = number * 10; 

while (number >= 1) 
{
     number = number / 10;
     digits++;
 } 

Console.WriteLine($"\nКоличество цифр в числе : {digits}");