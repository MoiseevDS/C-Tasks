//   Является ли число четным
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 1)
{
    Console.WriteLine("число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}