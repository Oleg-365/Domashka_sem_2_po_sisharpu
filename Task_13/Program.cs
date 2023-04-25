//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Пример:
//645 -> 5,
//78 -> третьей цифры нет,
//32679 -> 6.

int rand = new Random().Next(80, 120);

Console.WriteLine("Рамдомное число:  " + rand);

FistNumber(rand);
Console.WriteLine(" " + rand);
//Console.WriteLine(" " + rand);

int FistNumber(int x)
{
    int a = x % 10;
    if (a>0)
     {
        rand = a;
     }   
    else
    {
       Console.Write("Третьей цифры нет"); 
    }
    return x;
}
//Console.WriteLine(" " + rand);