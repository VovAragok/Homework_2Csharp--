// Напишите программу которая принимает на ввод трехзначное число и на выходе показывает вторую цифру этого числа 

int secondNumber(int i) 
{ 
    int secondDigit = (i / 10) % 10;
    return secondDigit;
}

int number  = 0;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    string s1 = Console.ReadLine();
    if (int.TryParse(s1, out number))
    {
        if(number > 99 && number < 1000)
        {
            int second = secondNumber(number); 
            Console.WriteLine($"Вторая цифра числа {number} равна {second}");
            break;
        }
        else 
        {
            Console.WriteLine("Число не трехзначное!");
        }
    }
    else 
    {
        Console.WriteLine("Ошибка ввода!");
    }
}