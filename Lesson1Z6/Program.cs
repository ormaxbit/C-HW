Console.WriteLine("Vvedi chislo dlya proverki na chetnost");
int X = int.Parse(Console.ReadLine() ?? "");
if ((X % 2) == 0)
{
    Console.WriteLine($"DA, Chislo {X} - chentoe");
}
else
{
    Console.WriteLine($"NET, Chislo {X} - nechentoe");
}