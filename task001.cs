// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a number in the range [10000;99999]: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number % 100000 / 10000;
int digit2 = number % 10000 / 1000;
int digit4 = number % 100 / 10;
int digit5 = number % 10;

if (number > 9999 && number < 100000)
{
    if (digit1 == digit5 && digit2 == digit4)
        Console.WriteLine($"This number {number} is a palindrome");
    else 
        Console.WriteLine($"This number {number} isn't a palindrome");
}
else
    Console.WriteLine("Try again");