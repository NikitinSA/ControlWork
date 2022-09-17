Console.Clear();

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayFirst = new string[size];
string[] resultArray = new string[arrayFirst.Length];

FillArray(arrayFirst, size);
Console.WriteLine();
Console.Write("Введенный массив: ");
PrintArray(arrayFirst);
Console.WriteLine();
NumberOfCharacters(arrayFirst, resultArray);
Console.Write("Массив из строк длина которых меньше или равна 3 символам: ");
PrintArray(resultArray);

void FillArray(string[] arrayFirst, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        arrayFirst[i] = Convert.ToString(Console.ReadLine());
    }
}

void NumberOfCharacters(string[] arrayFirst, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <= 3)
        {
            resultArray[count] = arrayFirst[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}