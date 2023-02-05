// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int InputNumber(string num)
{
    System.Console.WriteLine(num);
    return Convert.ToInt32(Console.ReadLine());
}

void QubeSequence(int n)
{
    for (int i = 1; i <= n; i++)
    {
        double qube = Math.Pow(i, 3);
        System.Console.Write(qube + " ");
    }
}

int N = InputNumber("Введите число");

QubeSequence(N);
