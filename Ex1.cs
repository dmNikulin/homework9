// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());



string RangeNumbers (int number)
{
    string nums = String.Empty;
    if (number == 0) return "0";

    nums = Convert.ToString(number + RangeNumbers(number - 1));

    return nums;
}

Console.WriteLine(RangeNumbers(number));
