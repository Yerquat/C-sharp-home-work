Console.Clear();
int numberA = new Random().Next(0, 100);
int numberB = new Random().Next(0, 120);
 // numberA != numberB;

int max = numberA;

if (numberA > max) max = numberA;
    
if (numberB > max) max = numberB;

Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine($"MAX = {max}");

