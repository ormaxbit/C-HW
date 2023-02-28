Console.WriteLine("Vvedi chislo dlya nahoczdenia chetnogo factoriala");
int X = int.Parse(Console.ReadLine() ?? "");    // vvodim predel poiska
int n = X/2;                                    // nahodim max kolichestvo iskomih chisel
int j = 0;                                      // obyavlyaem chetchik
int[] numbers = new int[n];                     // sozdaem massiv razmerom ishodya iz max kolichestva iskomih chisel
for (int i = 2; i <= ((X/2)*2); j++)
    {
        numbers[j] = i;
        i = i+2;
    }
var str = string.Join(" ", numbers);            // preobrazuem massiv v stroku
Console.WriteLine($"{str}");                    // vivod znachenii