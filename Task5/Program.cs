//Задача 10 Вторая цифра 3х значного чисала
Console.Clear();
Console.Write("Введите 3-х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10;
int n3 = n1 % 10;
Console.WriteLine(n3);