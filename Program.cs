// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число ");
String strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
int index = 2;

while (number >= index)
{
    Console.Write(index + " ");
    index = index + 2;
}
