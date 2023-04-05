// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

void Print(string[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

string[] CreateArray(int size)
{
  string[] arr = new string[size];

  for (int i = 0; i < size; i++)
  {
    Console.WriteLine($"Введите {i+1} значение:");
    arr[i] = Console.ReadLine()!;
  }
  return arr;
}




Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

string[] array = CreateArray(num);
Print(array);