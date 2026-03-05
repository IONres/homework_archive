/*Задача 2 НЕОБЯЗАТЕЛЬНАЯ.
Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) .
 Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, сами значения 
 предикатов случайные, проверяем это утверждение 100 раз, выводим на экран , сколько времени отработала программа. 
 В конце вывести результат проверки истинности этого утверждения.*/
using System;
using System.Diagnostics;
var sw = new Stopwatch();
Console.Clear();
sw.Start();
int check = 1; // проверка для вывода результата
for (int count = 0; count < 100; count++)
{
    Random rnd = new Random();
    int index = rnd.Next(5, 26);
    bool[] leftPart = new bool[index];
    bool[] rightPart = new bool[index];
    var random = new Random();

    for (int i = 0; i < leftPart.Length; i++)
    {
        leftPart[i] = random.Next(2) == 1; // значения для левой части равенства вида X ⋁ Y ⋁ Z
        rightPart[i] = !leftPart[i];// значения правой часть ¬X ⋀ ¬Y ⋀ ¬Z
    }

    for (int i = 1; i < leftPart.Length; i++)  // решение правой и левой части неравенства
    {
        leftPart[0] = (leftPart[0] || leftPart[i]); //решение правой части X ⋁ Y ⋁ Z
        rightPart[0] = (rightPart[0] && rightPart[i]);// решение левой части ¬X ⋀ ¬Y ⋀ ¬Z
    }

    if (!leftPart[0] != rightPart[0]) // проверка равенства
    {
        check = 0;
        break;
    }
}
if (check == 0) Console.WriteLine("равенство ошибочно");
else
    Console.WriteLine("равенство подтверждается");
sw.Stop();
Console.WriteLine($" Затраченное время : {sw.ElapsedMilliseconds} мс");

