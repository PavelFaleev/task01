//                                         Homework Unit 1 

//1) Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите ваше первое число для сравнения:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("А сейчас второе число):");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if(a > b) max = a;
if(a < b) max = b;

Console.WriteLine($"Самое большое число из чисел {a}, {b} : = {max}");





                       //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Здраствуйте !!! Введите перовое число для сравнения.:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("А теперь Второе число.:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("А теперь Третье число.:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

    if(a > b) max = a;
    if(a > c) max = a;


    if(b > a) max = b;
    if(b > c) max = b;



    if(c > a) max = c;
    if(c > b) max = c;



Console.WriteLine($"Самое большое число из чисел {a}, {b}, {c} : = {max}");





