Console.WriteLine("Vvedi 1-e chislo ");
int Num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi 2-e chislo ");
int Num_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi 3-e chislo ");
int Num_c = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(Num_c, Math.Max(Num_a, Num_b));
Console.WriteLine($"Iz chisel {Num_a},{Num_b},{Num_c} samoe bolshoe - {max}");