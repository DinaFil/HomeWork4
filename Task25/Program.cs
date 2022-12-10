// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (т.е нужно решить задачу без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени, являющийся натуральным числом: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0;
if (n <= 0) Console.WriteLine("Введенный показатель степени не является натуральным числом");
else
{while (i < n)
 {
result *= a;
i++;
  }
}
Console.WriteLine($"Число {a} в степени {n} равно {result}");

