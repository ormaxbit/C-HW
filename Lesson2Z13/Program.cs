// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Res = 0;
while(true)
{
    Console.Write("Vvedi chislo: ");
    int X = int.Parse(Console.ReadLine() ?? "");
    if (X/100 != 0)
    { 
        if (X/100 > 10)
        {
            X = X / 10;
        }
        Res = X%10;
        break;
    }
    Console.WriteLine("Oshibka! Chislo menshe neobhodimogo razryada!");
}
Console.Write($"3-ya cifra chisla - {Res}");
