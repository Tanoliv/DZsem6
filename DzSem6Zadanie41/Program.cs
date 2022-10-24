//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4       


/*Console.Write("Введите количество элементов массива:\t");
int size = int.Parse(Console.ReadLine()!);
int[] mass = new int[size];

Console.WriteLine("Вывод массива:");

for(int i =0; i < mass.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}:\t");
    mass[i] = int.Parse(Console.ReadLine()!);
}

 for(int i = 0; i < mass.Length; i++)
 {
    //Console.WriteLine($"\t{mass[i]}");
     
    Console.Write(String.Join(" ", mass[i]));
    Console.WriteLine();
 }
 //Console.ReadLine();

 int result =0;
 for(int i = 0; i < mass.Length; i++)
 {
    if(mass[i] > 0)
    { 
        result++;
        
    }   
     
 }

 Console.WriteLine($"Количество четных элементов в массиве = {result}");*/



Console.Write("Введите количество элементов массива:\t");
int size = int.Parse(Console.ReadLine()!);
int[] mass = new int[size];

Console.WriteLine("Вывод массива:");

for(int i =0; i < mass.Length; i++)
{
    Console.Write($"Введите элемент массива с индексом {i}:\t");
    mass[i] = int.Parse(Console.ReadLine()!);
}

 for(int i = 0; i < mass.Length; i++)
 {
    Console.Write(String.Join(" ", mass[i]));
    Console.WriteLine();
 }

 Console.WriteLine($"Количество элементов в массиве  > 0 = {Method()}");


int Method()
{
     int result =0;
    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] > 0)
        { 
           result++;        
        }        
    }
    return result;
}
