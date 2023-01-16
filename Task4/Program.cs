// Все чётные числа от 1 до N
Console.Clear();
Console.Write("Веедите число :");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
