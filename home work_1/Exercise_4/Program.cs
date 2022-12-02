Console.Clear();

Console.WriteLine("Введите число >= 2: ");
int N = int.Parse(Console.ReadLine());
int i = 2;

while (i <= N)
{    
//int b = i;
Console.WriteLine($"{i}");
i = i + 2;
}