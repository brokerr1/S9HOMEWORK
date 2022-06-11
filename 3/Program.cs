// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат функции Аккермана: {rec(numberM,numberN)}");
int rec(int n, int m)
{
    if (n == 0)
        return (m + 1);
    if (m == 0)
        return rec(n - 1, 1);
    return rec(n - 1, rec(n, m - 1));
}
