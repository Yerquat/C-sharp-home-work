Console.Clear();
int numberA = new Random().Next(0, 100);
int numberB = new Random().Next(0, 100);

int max = numberA;
if (numberA > numberB) 
    numberA = max;
else
    numberB = max;
    Console.WriteLine(numberA);
    Console.WriteLine(numberB);
    Console.WriteLine(max);
