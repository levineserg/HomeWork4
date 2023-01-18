// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Веедите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
int product = 1;
for (int count = 1; count <= number2; count++)
{
     product *= number1;
}
Console.WriteLine(product);