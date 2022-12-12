// Написать программу, которая из имеющегося массива строк формирует 
// массив сторок, длина которых меньше либо равна 3 символа 

Console.Write("Введите количество элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
string[] primaryArray = new string[size];

// Метод, создающий массив
string [] FillArray (string [] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// Метод, сортирующий массив
string[] SortArray (string [] array)
{
    int count = 0;
    string arraySize = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arraySize = array[i];
        if (arraySize.Length <= 3) count++;
    }
    string[] newArray = new string [count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arraySize = array[i];
        if (arraySize.Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

// Метод, печатающий массив
void PrintArray (string [] array)
{
	if (array.Length == 0) Console.WriteLine("Массив не имеет значений!");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"  [{array[i]}]");
		}
    Console.WriteLine();
}

// Пользовательский код

FillArray(primaryArray);
string[] newArray = SortArray(primaryArray);
Console.WriteLine("Первоначальный массив");
PrintArray(primaryArray);
Console.WriteLine("Массив с длиной строк меньше либо равна 3 символа");
PrintArray(newArray);