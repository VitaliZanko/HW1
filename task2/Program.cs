// Task1
int max = 0, min = 0;

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    max = a;
    min = b;
}
    else
    {
        max = b;
        min = a;
    }
Console.WriteLine("max = " + max + " и " + "min = " + min);