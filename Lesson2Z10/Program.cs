// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Res = 0;
while(true)
{
    Console.Write("Vvedi 3-h znachnoe chislo: ");
    int X = int.Parse(Console.ReadLine() ?? "");
    if (X/100 != 0 && X/100 < 10)
    { 
        Res = (X%100)/10;
        break;
    }
    Console.WriteLine("Oshibka! Chislo ne 3-h znachnoe!");
}
Console.Write($"2-ya cifra 3-h znacnogo chisla - {Res}");