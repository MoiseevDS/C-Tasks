//Максимальное число из 3х
Console.Clear();
Console.Write("Введдите 1-ю цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введдите 2-ю цифру: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введдите 3-ю цифру: ");
int a = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n >= max)
    max = n;
if (m >= max)
    max = m;
if (a >= max)
    max = a;
Console.Write("Наибольшее число: ");
Console.WriteLine(max);
