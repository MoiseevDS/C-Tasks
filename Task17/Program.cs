// Гипотеза Гольдбаха

Console.Clear();
int fGoldbach(int x)
{
    int p = 2;
    int f = 1;

    while (p * p <= x)
    {
        if (x % p == 0)
        {
            f = 0;
            break;
        }
        p += (p % 2) + 1;
    }
    return f;
}


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n / 2; i++)
{
    int a = fGoldbach(i);
    int b = fGoldbach(n - i);
    if (a == 1 && b == 1)
    {
        Console.WriteLine($"{i}, {n - i}");
        break;
    }
}
