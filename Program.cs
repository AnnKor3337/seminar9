// Задача 64

/* int count(int n)
{
    if (n / 10 != 0)
        return 1 + count(n / 10);
    else
        return 1;
}

Console.WriteLine("Введите число, в котором посчитаем количество цифр: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество цифр: ");
Console.WriteLine(count(n)); */

// Задача 66

/* Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = m;

if (m > n)
{
    m = n;
    n = count;
}

NatSumm(m, n, count = 0);

void NatSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов: {summ}");
        return;
    }
    NatSumm(m, n - 1, summ);
} */
