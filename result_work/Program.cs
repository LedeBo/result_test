// Задание
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[5] { "888", "18", "test", "work", "5final" };
string[] arr = new string[array.Length];

void ResultArray(string[] array, string[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count++;
        }
    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($" {array[i]} ");
    }
    System.Console.WriteLine();
}

ResultArray(array, arr);
PrintArray(arr);
