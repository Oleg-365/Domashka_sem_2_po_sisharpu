//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Пример:
//645 -> 5,
//78 -> третьей цифры нет,
//32679 -> 6.

int rand = new Random().Next(80, 120);

Console.WriteLine("Рамдомное число:  " + rand);

ThreeNumber(rand);

int ThreeNumber(int x)
{
    int a = (x % 10);
    if (rand < 100)
     {
        Console.Write("Третьей цифры нет"); 
      
     }   
    else 
    {
      if (rand > 100)
      {
       rand = a;
      Console.WriteLine(+ rand);
      }

    }
    return x;
}
