//Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// (без использования строк)

//Вариант 1

Console.Clear();
Console.WriteLine("Введите число.Если число дробное, разделяйте целую и дробную часть запятой \",\". ");
Console.Write ("\nЧисло: ");
decimal number = Convert.ToDecimal (Console.ReadLine ());
number = Math.Abs(number);
int digits1=0;
int digits2=0;

if (number==0)
    digits1=1;

while (number%1 >0)
    if (Math.Floor(number) != 0)
      
        {    number=number*10;
        }
    else 
        {number=number*10;
        digits1=digits1+1;
        }
 
while (number != 0)
{
    digits2 = digits2+1;
    number=Math.Floor(number/10);
}
Console.Write ("Количество цифр в числе: ");
Console.WriteLine(digits1+digits2);