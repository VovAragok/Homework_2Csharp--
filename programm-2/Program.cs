// // Напишите программу , которая выводит третью цифру заданного числа или сообщает что третьей цифры нет 


// Вариант решение через строку

// string secondNumber(string s) 
// {   if (s.Length < 3)
//     {
//         return "третьей цифры нет";
//     }
     
//     else 
//     {
//         return $"третья цифра числа = {s[2]}";
//     }

// }


// int number  = 0;
// while (true)
// {
//     Console.Write("Введите трехзначное число: ");
//     string s1 = Console.ReadLine();
//     if (int.TryParse(s1, out number))
//     {
//         Console.WriteLine(secondNumber(s1));
//         break;
//     }
//     else 
//     {
//         Console.WriteLine("Это не число!!!");
//     }
// }







// Вариант решения через инт


string thirdNumber(int i) 
{    while (i>99)
    {
        if  (i < 999)
        {   
           
            return($" третья цифра =  {i%10}");
        } 
        i = i/10;      
    }  
    return "третьей цифры нет";
}
    


int number  = 0;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    string s1 = Console.ReadLine();
    if (int.TryParse(s1, out number))
    {
        Console.WriteLine(thirdNumber(number));
        break;
    }
    else 
    {
        Console.WriteLine("Это не число!!!");
    }
}







