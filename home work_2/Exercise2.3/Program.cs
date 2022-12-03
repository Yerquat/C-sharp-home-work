//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
//if (a == 1)
    //Console.WriteLine("Понедельник");
    //if (a == 2)
    //Console.WriteLine("Вторник");
    //if (a == 3)
    //Console.WriteLine("Среда");
    //if (a == 4)
    //Console.WriteLine("Четверг");
    //if (a == 5)
    //Console.WriteLine("Пятница");
//else

Console.Clear();
Console.WriteLine("Введите число от 1 до 7, чтобы определить выходной ли сегодня день: ");
int a = int.Parse(Console.ReadLine());

if (a > 7)
Console.WriteLine("такого дня недели нет"); 
else  
    if (a > 5 & a < 8)
    Console.WriteLine("Выходной день");
    else
    {
        while(a < 6)
        {
            a = a + 1;
        }
    Console.WriteLine("Рабочий день");
    }
