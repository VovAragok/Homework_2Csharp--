// Напишите программу которая принимает на вход цифру , обозначающую день недели и проверяет является ли этот день выходным.
string Days(int i)
{
    if (i == 1)
    {
        return "Понедельник не выходной";
    }
    else if (i == 2)
    {
        return "Вторник не выходной";
    }
    else if (i == 3)
    {
        return "Среда не выходной";
    }
    else if (i == 4)
    {
        return "Четверг не выходной";
    }
    else if (i == 5)
    {
        return "Пятница не выходной";
    }
    else if (i == 6)
    {
        return "Суббота выходной";
    }
    else  if(i == 7)
    {
        return "Воскресенье выходной";
    }
    else 
    {
        return "ошибка";
    }
}


int number = 0;
while (true)
{
    Console.Write("Введите день недели:");
    string s1 = Console.ReadLine();
    if (int.TryParse(s1, out number))
    {
        if(number > 0 && number < 8)
        {
            Console.WriteLine($"{Days(number)}");
            break;
        }
        else 
        {
            Console.WriteLine("Число неккоректное!");
        }
    }
    else 
    {
        Console.WriteLine("Это не число!");
    }
}

