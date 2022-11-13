// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Заполнение массива производит пользователь.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Console.WriteLine("Введите 8 чисел : ");
for (int i=0; i<8; i++)
{
    array[i] = System.Convert.ToInt32(Console.ReadLine());   
}

for (int i=0; i<8; i++)
{
    Console.Write($" {array[i]} ");   
}

Console.ReadKey();
