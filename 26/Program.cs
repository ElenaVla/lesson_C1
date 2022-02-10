// 26. Определить количество цифр в числе
class Program
{
    static void Main(string[] args)
    {
        Chislo chislo = new Chislo();
        chislo.Metod();
    }
}
class Chislo
{
    string i;
    int kolvo;
 
    public void Metod()
    {
        Console.Write("Введите число: ");
        i=Console.ReadLine();
        int a=0;
     
        while(a<=i.Length)  
        {
                kolvo= a++;
        }
        Console.WriteLine("Количество цифр {0}",kolvo);
        Console.ReadKey();
    }
}