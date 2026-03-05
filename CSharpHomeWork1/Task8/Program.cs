// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number < 2)
{
    Console.WriteLine(" Четных чисел больше 1 не обнаружено");
}
else
{
    Console.WriteLine($" \nчетные числа от 1 до {number}: ");
    while (count <= number)
        {
            if ( count % 2 == 0)
            {
                Console.WriteLine($"{count}  ");
             }
             count++;        }
}


