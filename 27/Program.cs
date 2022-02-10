// 26. Возведите число А в натуральную степень B используя цикл
using System;

namespace My3
{
     class Program
     {
          static void Main(string[] args)
          {
               // double x = 5;
               // int stepen = 4;
              Console.Write("Введите A = ");              
              int A = int.Parse(Console.ReadLine());          //Ввод x
              Console.Write("Введите B= ");
              int stepen = int.Parse(Console.ReadLine());
              
               Console.WriteLine("A^B = " + Math.Pow(A, stepen));
            
               Console.ReadKey();
          }
     }
}