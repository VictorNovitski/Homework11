// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите длину массива: ");
int massLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[massLength];
for (int i = 2; i <= massLength; i++)
if (i % 2 == 0)
Console.Write(i + " ");

