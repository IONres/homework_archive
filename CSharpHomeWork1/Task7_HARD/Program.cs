// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, 
//которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа 
//или говорит, что такой цифры нет. Через строку решать нельзя.

Console.Clear ();

Console.Write (" Введите целое  число: ");
int num = Convert.ToInt32 (Console.ReadLine ());
      

int number = Math.Abs(num);
int figure = 0;
int RevNumber=0;

if (number <100) 
    Console.WriteLine ("\n В числе отсутсвует третья цифра. ");
else if (number>=1000)      
 {
     
    while (number>0)
    {
        figure = number%10;
        number=number/10;
    
        RevNumber=RevNumber*10+figure;
    }
    
    Console.WriteLine ($"\n третья цифра слева : {RevNumber%1000/100}") ;

 }                    
else 
    Console.WriteLine (number%10) ;      