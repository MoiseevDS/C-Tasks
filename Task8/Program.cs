// Дополнительная задача "Второе максимальное значение"
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int max = 0, max2 = 0;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max)
    {
        max2 = max;
        max = n;
    }
    else if (n > max2 && n != max)
        max2 = n;
}
Console.WriteLine(max2);