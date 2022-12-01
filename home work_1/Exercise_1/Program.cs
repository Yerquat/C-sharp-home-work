Console.Clear();
int numberA = new Random().Next(0, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(0, 100);
Console.WriteLine(numberB);
 // numberA != numberB;
int max = numberA;
//if (numberA > max) max = numberA;
  if (numberB > max) max = numberB;
Console.WriteLine($"MAX = {max}");

