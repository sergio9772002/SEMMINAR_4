/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
int prOfRange(int start, int finish)
{
    int pr = 1;
    for (int i = start; i <= finish; i++)
    {
        pr *= i; // sum = sum + i;
    }
    return pr;
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
int userNumber = getNumberFromUser("Введите N");
int pr = prOfRange(1, userNumber);
Console.WriteLine($"Произведение чисел от 1 до {userNumber} = {pr}");
