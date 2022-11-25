/* Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void Power()
{
    Console.WriteLine("Задача 25");
    Console.WriteLine();
    Random rand = new Random();
    int R1 = rand.Next(10);
    Console.WriteLine("Сгенерировано случайное основание степени: " + R1 );
    int R2 = rand.Next(10);
    Console.WriteLine("Сгенерирован случайный показатель степени: " + R2);
    int sum = 1;
    int count = 0;
    while (count < R2)
    {
        sum = sum * R1;
        count++;
    }
    Console.WriteLine($"Возводя {R1} в степень {R2} получим {sum}");
    Console.WriteLine();
}
Power();

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
//void Sum();

void Sum()
{
    Console.WriteLine("Задача 27");
    Console.WriteLine();
    Random rand = new Random();
    int R = rand.Next(100000);
    Console.WriteLine("Сгенерировано случайное число: " + R );
    
    int sum = 0;
    int newR = R;

    while (R > 0)
    {
        int subject = newR % 10;
        sum = sum + subject;
        newR = R / 10;
        R = newR;
    }
    Console.WriteLine("Сумма цифр числа = " + sum);
    Console.WriteLine();
}
Sum();

/* Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
6, 1, -33 -> [1, 6, -33] */

void FillArray(int[] N)
{
    Random rand = new Random();
    int size = N.Length;
    for (int i = 0; i < size; i++)
    {
        N[i] = rand.Next(-99, 100);
    }
}

void PrintArray(int[] N)
{
    int size = N.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(N[i] + " ");
    }
}
void PrintAbs(int[] N)
{
    Console.WriteLine();
    int size = N.Length;
    Console.Write("Возвращение модулей элементов: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(Math.Abs(N[i]) + " ");
    }
}

void PrintSort(int[] N)
{
    
    Console.WriteLine();
    int size = N.Length;
    Console.Write("Сортировка по возрастанию модуля: ");
    int i = 0;
    for (i = 0; i < size; i++)
    {
    Array.Sort(N, (x, y) => Math.Abs(x).CompareTo(Math.Abs(y)));
    Console.Write(Math.Abs(N[i]) + " ");
    }
}

void ArrayAbsSort()
{
    Console.WriteLine("Задача 29");
    Console.WriteLine();
    Console.Write("Генерация массива (-100, 99): ");
    int size = 8;
    int[] array = array = new int[size];
    FillArray(array);
    PrintArray(array);
    PrintAbs(array);
    PrintSort(array);
    Console.WriteLine();
}
ArrayAbsSort();