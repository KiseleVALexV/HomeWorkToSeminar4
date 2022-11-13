// Напишите программу, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. 
// Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int A, int B)
{
    int resault = A;
    for (int i = 1; i < B; i++)
    {
        resault = resault * A;
    }
    return resault;
}

Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} = {Exponentiation(a, b)}");

Console.ReadKey();
