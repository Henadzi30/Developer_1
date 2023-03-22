// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

// Initial data block
int desiredElementLength = 3;
string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] GetNeedArray(string[] array)
{
    int arrayLength = array.Length;
    string[] needArray = new string[arrayLength];
    int elements = 0;

    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i].Length <= desiredElementLength)
        {
            needArray[elements] = array[i];
            elements++;
        }
    }
    string[] desiredArray = new string[elements];
    for (int i = 0; i < elements; i++)
    {
        desiredArray[i] = needArray[i];
    }
    return desiredArray;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write($"['{string.Join("', '", array)}']");
    }
}
void ResultTextProcessingMethod(string[] array)
{
    string[] myArray = GetNeedArray(array);
    PrintArray(array);
    Console.Write($"  =>  ");
    PrintArray(myArray);
    Console.WriteLine();
}
ResultTextProcessingMethod(array1);
ResultTextProcessingMethod(array2);
ResultTextProcessingMethod(array3);
