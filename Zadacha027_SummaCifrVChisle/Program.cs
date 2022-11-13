// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// Для решения задания использование цикла for является обязательным условием
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант с целыми числами:

int SumOfIntDigits(int num)
{
    int summa = 0;

    if (num < 0)
    {
        num = num * (-1);
    }

    while (num >= 1)
    {
        summa = summa + num % 10;
        num = (int)(num/10);
    }
    return summa;
}

Console.WriteLine("Введите целое число : ");
int num = System.Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {num} равна : {SumOfIntDigits(num)}");
Console.ReadKey();

// Вариант для всех чисел:

int SumOfDigits(double number)
{
    int sum = 0;
    string strNumber = number.ToString();
    int lenNumber = strNumber.Length;

    for (int i = 0; i < lenNumber; i++)
    {
        if (strNumber[i] >= 48 && strNumber[i] <= 57) //
        {
            sum = sum + System.Convert.ToInt32(strNumber[i]) -48;
        }
    }
    return sum;
}

Console.WriteLine("Введите число : ");
double number = System.Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} равна : {SumOfDigits(number)}");

Console.ReadKey();
