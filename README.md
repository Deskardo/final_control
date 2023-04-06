# Программа для формирования массива из значений до трех символов длиной

## Ввод данных
1. При старте программы выполняется команда очистки терминала.
2. Выполняется запрос желаемого размера массива
3. Запускается метод наполнения массива данными

### Код метода наполнения массива
```
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
```

---

## Выборка из массива нужных значений и перенос их в новый массив

1. В теле метода ThreeArray работает условный оператор if, для определения соответствует ли длина значения с индексом i, требуемому условию.
2. Цикл выбирает все значения подходящие по условию и наполняет ими новый массив.

### Код метода наполнения нового массива

```
void ThreeArray(string[] arr, string[] arr2)
{
  int j = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      arr2[j] = arr[i];
      j++;
    }
  }
}
```

---

## Вывод на печать

1. С помощью метода Print выводим изначальный массив
2. Повторно запрашиваем метод Print для вывода искомого массива.

### Код метода Print

```
void Print(string[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}
```