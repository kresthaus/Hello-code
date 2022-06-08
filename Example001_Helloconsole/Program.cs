// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите число => ");                 // Это вывод на экран приглашения
string paramString = Console.ReadLine();            // Чтение строки с клавиатуры
int paramInt = int.Parse(paramString);              // Преобразование строки в число
Console.WriteLine("Вы ввели число: " + paramInt);   // Вывод этого числа
int result = paramInt * paramInt;                   // Вычисление квадрата
Console.WriteLine($"Результат (квадрат числа {paramInt}) = {result}");  // Вывод результата

if (result > 20)
{
Console.WriteLine("Результат получился больше 20");
Console.WriteLine("До свиданья");
}
else
{
Console.WriteLine("Результат не больше 20");
Console.WriteLine("До свиданья");
}