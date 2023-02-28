// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write($"Vvedi den nedeli: \n Будни: \n Понедельник - 1 \n Вторник - ... 2 \n Среда - ..... 3 \n Четверг - ... 4 \n Пятница - ... 5 \n Выходные: \n Суббота - ... 6 \n Воскресенье - 7 \n " );
int X = int.Parse(Console.ReadLine() ?? "");
string str;
if ( X >= 1 && X <= 5)
    {
        str = "Будни, ";
        if (X == 1)
            str = str + "Понедельник";
        else if (X == 2)
            str = str + "Вторник";
        else if (X == 3)
            str = str + "Среда";
        else if (X == 4)
            str = str + "Четверг";
        else if (X == 5)
            str = str + "Пятница";
    }
else if ( X == 6 && X == 7)
    {
        str = "Выходные, ";
        if (X == 6)
            str = str + "Суббота";
        else if (X == 7)
            str = str + "Воскресенье";
    }
else 
    str = "Ошибка! В неделе 7 дней!";
Console.Write($"{str}");