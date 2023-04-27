//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Пример:
//6  -> да,
//7  -> да,
//1  -> нет.

Console.WriteLine("Является ли день выходным?");

int NubmerDayWeek = new Random().Next(1, 8);

Console.WriteLine("Рамдомное число:  " + NubmerDayWeek);

DayWeek(NubmerDayWeek);
int DayWeek(int n)
{
    int r = n * 1;
    if (r > 5)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
    return n;
}


