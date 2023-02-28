Console.WriteLine("Vvedi 1-e chislo ");
int Number_a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Vvedi 2-e chislo ");
int Number_b = int.Parse(Console.ReadLine() ?? "");
if (Number_a > Number_b)
{
    Console.WriteLine($"{Number_a} bolshe {Number_b}");
}
else if (Number_a < Number_b)
{
    Console.WriteLine($"{Number_b} bolshe {Number_a}");
}
else 
{
    Console.WriteLine($"Eti chisla ravni");
}