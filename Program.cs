internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(
            "Напишите цифру необходимого способа ввода массива строк: 1 - Автозаполнение / 2 - Вручную, через запятую"
        );
        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
                string[] arr1 = { "Hello", "2", "world", ":-)" };
                string[] arr2 = { "1234", "1567", "-2", "computer science" };
                string[] arr3 = { "Russia", "Denmark", "Kazan" };

                int max_word_length = 3;

                string[] GetShortWordsArray(string[] array) // метод преобразования в массив строк с менее чем 3 символами
                {
                    int length = array.Length;
                    string[] result = new string[length];
                    int count = 0;

                    for (int i = 0; i < length; i++)
                    {
                        if (array[i].Length <= max_word_length)
                        {
                            result[count] = array[i];
                            count++;
                        }
                    }
                    return result;
                }

                void PrintArray(string[] array)         // метод вывода на печать
                {
                    if (array.Length == 0)
                    {
                        Console.WriteLine("Строка пустая");
                    }
                    else
                    {
                        Array.ForEach(array, (str) => Console.Write($"{str} "));
                        Console.WriteLine();
                    }
                }

                void PrintTask(string[] array) // метод вывода укороченных массивов
                {
                    Console.WriteLine("Начальный массив:");
                    PrintArray(array);
                    string[] shortArray = GetShortWordsArray(array);
                    Console.WriteLine(
                        $"Массив из строк, длина которых меньше, либо равна {max_word_length} символам: "
                    );
                    PrintArray(shortArray);
                    Console.WriteLine();
                }

                PrintTask(arr1);
                PrintTask(arr2);
                PrintTask(arr3);
                break;
            case 2:
                Console.WriteLine("Введите массив с клавиатуры через запятую: ");
                string user_array = Console.ReadLine()!;
                string[] words = user_array.Split(',');

                int max_word = 4;

                string[] GetShortWordsArr(string[] array)
                {
                    int length = array.Length;
                    string[] result = new string[length];
                    int count = 0;

                    for (int i = 0; i < length; i++)
                    {
                        if (array[i].Length <= max_word)
                        {
                            result[count] = array[i];
                            count++;
                        }
                    }
                    return result;
                }

                void PrintArr(string[] array)
                {
                    if (array.Length == 0)
                    {
                        Console.WriteLine("Строка пустая");
                    }
                    else
                    {
                        Array.ForEach(array, (str) => Console.Write($"{str} "));
                        Console.WriteLine();
                    }
                }

                void TaskArr(string[] array) // метод вывода укороченных массивов
                {
                    Console.WriteLine("Начальный массив:");
                    PrintArr(array);
                    string[] shortArr = GetShortWordsArr(array);
                    Console.WriteLine(
                        $"Массив из строк, длина которых меньше, либо равна {max_word - 1} символам: "
                    );
                    PrintArray(shortArr);
                    Console.WriteLine();
                }
                TaskArr(words);
                break;
        }
    }
}
