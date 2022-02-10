// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.Write("Введите x = ");              
int x = int.Parse(Console.ReadLine());          //Ввод x
Console.Write("Введите y= ");
int y = int.Parse(Console.ReadLine());         //Ввод y
bool b = Proverka(x, y); 
Console.WriteLine("Точка лежит во второй четверти = {0}" , b);
Console.ReadKey();
bool Proverka(int x,int y)  
        {
 
            if (x < 0 & y > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }