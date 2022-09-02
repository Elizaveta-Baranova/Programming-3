// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (5 > number.Length || 5 < number.Length)
{
    Console.Write("Вы ввели не пятизначное число!");
}
else 
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write($"{number} является палиндромом.");
    } 
    else
{
    Console.Write($"{number} не является палиндромом.");
} 
}

