//задача 1 необязательная
//на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
Console.Clear();

Console.Write("Введите   число: ");
decimal number = Convert.ToDecimal(Console.ReadLine());
decimal initialNumber = number;
int power = 0;

while (Math.Truncate(Math.Abs(number)) > 9)
{
    number /= 10;
    power++;
}

number =
    Math.Truncate(number)
    + (number - Math.Truncate(number)) * 10
    - Math.Truncate((number - Math.Truncate(number)) * 10);

while (power > 1)
{
    number *= 10;
    power--;
}
if (initialNumber == number)
    Console.WriteLine("Нет второй цифры");
else Console.WriteLine(number.ToString("G29"));
