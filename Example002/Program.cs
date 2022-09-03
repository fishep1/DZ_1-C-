Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b)
if (a > c)
{
    max = a;
}
if (b > a)
if (b > c) 
{
    max = b;
}
if (c > b)
if (c > a) 
{
    max = c;
}
    Console.WriteLine("Максимальное число " + max);