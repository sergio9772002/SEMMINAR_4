﻿/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
int getNumberOfDigits(int number)
{
    int numberOfDigit = 0;
    while (number > 0)
    {
        number /= 10; // number = number / 10;
        numberOfDigit++;
        Console.WriteLine(number);
    }
    return numberOfDigit;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int userNumber = getNumberFromUser("Введите число");
int numberOfDigit = getNumberOfDigits(userNumber);
Console.WriteLine($"Количество цифр в числе {userNumber} = {numberOfDigit}");
