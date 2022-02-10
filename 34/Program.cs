// 34. Написать программу замену элементов массива на противоположные
int[] array = new int[6];
int[] arrayAnother = new int[6];
for (int i=0; i<array.Length; i++)
{
   array [i]=new Random().Next(-6, 6);
   arrayAnother [i] = array [i]*(-1);
}
for (int i=0; i<array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine(" ");
for (int i=0; i<array.Length; i++)
{
Console.Write($"{arrayAnother[i]} ");
}