// Создайте коллекцию (массив) с 10 случайными числами.
// Выведите в консоль номер минимального элемента.

using System;
class work_1_1
{
  static void Main()
  {
    int[] numbers = new int[10]; 
    Random rand = new Random(); 
    
    Console.Write("Массив: "); 
    for (int i = 0; i < 10; i++)
    {
        numbers[i] = rand.Next(100); 
    }
    var str = string.Join(" ", numbers);
    Console.WriteLine(str);
    
    int min = 100; 
    for (int i = 0; i < 10; i++)
    {
        if (numbers[i] < min) 
        {
            min = numbers[i]; 
        }
    }
    Console.WriteLine($"минимальный элемент: {min}"); 
  }
}

