// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultN(numberM, numberN));
int ResultN(int m, int n)
{
    if (m > n) return 0;
    else return m + ResultN(m + 1, n);
}
