// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine()!);

double x = Method();
double y = Method2();



Console.Write($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}; Точка пересечения прямых");  
    Console.Write($"  x = {x:F3}; y = {y:F3}");
     Console.WriteLine("");
    Console.WriteLine("");
        Console.WriteLine("Примечание: если x = -? y = -? ==> Прямые - параллельны или совпадают");

double Method()
{
    double result =0;
    double x = 0;  



 x = ( b2 - b1)/(k1 - k2);
 // x = Math.Round(x, 2);   


  
  if((k1 * x + b1) == (k2 * x + b2))
{

    result = x;
    
}
return result;
}

double Method2()
{
    
   double result =0; 
double y = 0;

    y = 5 * x +2;
    //y = Math.Round(y, 2);
  
  if((k1 * x + b1) == (k2 * x + b2))
{
        result = y;
   
}
return result;
}
