/*Задача 19 - HARD необязательная
Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
является ли оно палиндромом. Через строку нельзя решать само собой.
*/
Console.Clear();
System.Console.WriteLine("введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Является ли число {number} палиндромом? {IsPalindrome(number)}");

bool IsPalindrome(int number)
{
    int RevNumber = 0;
    for (int number1 = number; number1 != 0; number1 /= 10)
    {
        int rem = number1 % 10;
        RevNumber = RevNumber * 10 + rem;
    }

    bool result;
    if (number != RevNumber || number < 0)
        result = false;
    else
        result = true;
    return result;
}