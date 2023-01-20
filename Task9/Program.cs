// Task 19 Полиндром
Console.Clear();
Console.Write("Введите 5ти значное число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int revers = n % 10 * 10000 + (n / 10) % 10 * 1000 + (n / 100) % 10 * 100 + (n / 1000) % 10 * 10 + n / 10000;
while (n <= 9999 || n >= 1000000)
{
    Console.WriteLine("Не допустимое число!\nВведите 5ти значное число: ");
    n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

if (n == revers)
    Console.WriteLine("Введенное число ЯВЛЯЕТСЯ палиндромом!!!");
else
    Console.WriteLine("Введенное число НЕ ЯВЛЯЕТСЯ палиндромом!!!");
