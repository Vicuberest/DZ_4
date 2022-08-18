// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А ");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int numberB=Convert.ToInt32(Console.ReadLine());

int GetPow (int numberA, int numberB)
{
   int result=1;
   for (int i = 1; i <= numberB; i++)
   {
    result *= numberA;
   }
return result;
}
Console.WriteLine($"{numberA}^{numberB}={GetPow(numberA, numberB)}");