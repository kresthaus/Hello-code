//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> нет
//a = -3 b = 9 -> да
//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите первое число => ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе число => ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.WriteLine("Вы ввели первое число: " + paramInt1);
Console.WriteLine("Вы ввели второе число: " + paramInt2);
int result = paramInt2 * paramInt2; // Вычисление квадрата

if (result == paramInt1)
{
Console.WriteLine($"Да, число {paramInt1} является квадратом числа {paramInt2}"); // Вывод результата
}
else
{
Console.WriteLine("Нет, не является");
}