Console.Clear();

int numberA = new Random().Next(0, 100);
Console.WriteLine(numberA);

int numberB = new Random().Next(0, 100);
Console.WriteLine(numberB);

int numberC = new Random().Next(0, 100);
Console.WriteLine(numberC);

 // numberA != numberB; как поставить это условие в код?
int max = numberA;


if (numberB > max) max = numberB;

if (numberC > max) max = numberC;

//if (numberС > max) max = numberС;

Console.WriteLine($"MAX = {max}");

