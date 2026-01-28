//Задача:
//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина 
//которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Write("Исходный массив: ");
string[] originalArray = new string[] { "hello", "2", "world", ":-)" };
PrintArray(originalArray);

Console.Write("Массив из элементов длина которых <= 3 символа: ");
string[] newArray = new string[originalArray.Length];
int count = 0;

ResultArray(originalArray, newArray);
PrintArray(newArray);

void ResultArray(string[] originalArray, string[] newArray)
{
  for (int i = 0; i < originalArray.Length; i++)
  {
    if (originalArray[i].Length <= 3)
    {
      newArray[count] = originalArray[i]; count++;
    }
    else newArray[i] = string.Empty;
  }
}

void PrintArray(string[] Array)
{
 for (int i = 0; i < Array.Length; i++)
    {
 Console.Write($"{Array[i]} ");
    }
 Console.WriteLine();
}