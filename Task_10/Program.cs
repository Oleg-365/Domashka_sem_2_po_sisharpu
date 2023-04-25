//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
//Пример: 
//456 -> 5,
//782 -> 8,
//918 -> 1.

int rand = new Random().Next(100, 1000);

Console.WriteLine("Рамдомное число:  " + rand);

FistNumber(rand);

int FistNumber(int x)
{
    int a = x / 10;
    rand = a % 10;
    return x;
}
Console.WriteLine(" " + rand);