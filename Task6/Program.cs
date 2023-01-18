//Задача 13 Третья цифра многозначного чисала
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int resalt = 0;

while (n / 1000 != 0)
{
    resalt = n % 10;
    n = n / 10;
}
if (n / 100 == 0)
    Console.WriteLine("Нет 3-й цифры");
else
    Console.WriteLine($"Третяя цифра: {n % 10}");

