Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 2;
if (b == 0)
Console.WriteLine("Число a - четное");
if (b != 0)
Console.WriteLine("Число b - нечетное");
Console.WriteLine (b);
