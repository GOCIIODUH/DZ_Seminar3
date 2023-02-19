// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int u = 1;  //Цикл для удобства проверки всех вариантов
while (u == 1)
{
    System.Console.Write("Введите 5-ти значное число: ");
    string? number = Console.ReadLine();
    int i = number.Length;
    if (i == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            System.Console.WriteLine("Введенное число - палиндром");
        }
        else
        {
            System.Console.WriteLine("Введенное число - не палиндром");
        }
    }
    else
    {
        System.Console.WriteLine("Введено число не удовлетворяющее требованиям");
    }
}