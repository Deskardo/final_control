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
    Console.WriteLine($"Введите {i + 1} значение:");
    arr[i] = Console.ReadLine()!;
  }
  return arr;
}

void ThreeArray(string[] arr, string[] arr2)
{
  int j= 1;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      arr2[j] = arr[i];
      j++;
    }
  }
}


Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

string[] array = CreateArray(num);
string[] finalArray = new string[array.Length];

ThreeArray(array, finalArray);

Print(array);

Console.WriteLine("Обновленный массив с элемнтами длиной не более трех символов:");

Print(finalArray);