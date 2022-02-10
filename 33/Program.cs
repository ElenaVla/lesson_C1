// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int sumPos = 0, sumNeg = 0;

for(int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
    Console.Write($"{array[i],3} ");
    if(array[i]<0) sumNeg += array[i];
    if(array[i]>0) sumPos += array[i];
}
Console.WriteLine(" ");
Console.Write("Сумма положитльных чисел = ");
Console.Write($"{sumPos} ");
Console.WriteLine(" ");
Console.Write("Сумма отрицательных чисел = ");
Console.Write($"{sumNeg} ");