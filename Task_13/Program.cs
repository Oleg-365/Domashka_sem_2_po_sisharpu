//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Пример:
//645 -> 5,
//78 -> третьей цифры нет,
//32679 -> 6.

//int rand = new Random().Next(80, 120);

Console.Write("Введите число до 5 знаков:  ");

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введенное число:  " + number);

ThreeNumber(number);

int ThreeNumber(int x)
{
    //int a = (x % 10);

    if (number <= 99)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        if (number <= 999)
        {
            //int a = x % 100/10;
            int a = x % 10;

            number = a;

            Console.WriteLine("Третья цифра  " + a);
        }
        else
        {
            if (number <= 9999)
            {
                int a = x / 10 % 10;
                number = a;
                Console.WriteLine("Третья цифра  " + a);
            }
            else
            {
                if (number <= 99999)
                {
                    int a = x / 100 % 10;
                    number = a;
                    Console.WriteLine("Третья цифра  " + a);
                }
                else
                {
                  Console.Write("Веденное число больше пяти");
                }
            }
        }
    }
    return x;
}
