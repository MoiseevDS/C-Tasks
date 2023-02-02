// Task 41

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int cont = 1;
while (n != 0)
{
    Console.Write("Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        cont = cont + 1;
    }
}
Console.WriteLine($"Колличество чисел больше 0 = {cont}");