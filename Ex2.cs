// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SummaryRangeMN(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }

    if (m == n) return m;
    
    return m + (SummaryRangeMN(m + 1, n));
}

Console.WriteLine(SummaryRangeMN(numberM, numberN));
