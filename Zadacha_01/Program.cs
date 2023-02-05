// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

int InputNumber(string number)
{
    System.Console.WriteLine(number);
    return Convert.ToInt32(Console.ReadLine());
}
int number = InputNumber("Введите пятизначное число");

// System.Console.WriteLine(palindrom(number));

// palindrom(int number)
// {
    if (number > 0 && (number < 10000 || number > 99999))
    {
        System.Console.WriteLine("Вы ввели не пятизначное число, попробуйте ещё раз");
    }
    else if (number > 9999 && number < 100000)
    {
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            int result = number;
            while (result >= (Math.Pow(10, i + 1)))
            {
                result = result / 10;
            }
            array[i] = result % 10;
            System.Console.Write(array[i] + " ");
        }
        if ((array[0] == array[4]) && (array[1] == array[3]))
        {
            System.Console.WriteLine("Число является палиндромом");
        }
        else
        {
            System.Console.WriteLine("Число не является палиндромом");
        }
    }
    else if (number == 00000)
    {
        System.Console.WriteLine("Число является палиндромом");
    }

// }