/*Задача 19

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int A;
Console.Write("Введите число: ");
A = int.Parse(Console.ReadLine()!);

int total = 0 , B, rev;
B = A;

while(A > 0)
{
rev = A % 10;
total = (total * 10) + rev;
A = A / 10;
}
if(B == total)
Console.Write("Да");
else
Console.Write("Нет");

