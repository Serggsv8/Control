
string[] arrayString = new string[4];

for (int i = 0; i < arrayString.Length; i++)
{
    Console.Write($" Введите {i + 1} строку массива: ");
    arrayString[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Исходный массив:");
Console.WriteLine($"{PrintArray(arrayString)}");
Console.WriteLine();

int lengthControl = 3; // искомая длина элемента

int CheckArray(string[] array, int lengthControl) // метод определения кол-ва элементов короче чем lengthControl
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthControl) result++;
    }
    return result;
}

int numbers = CheckArray(arrayString, lengthControl); // переменная ,куда складываем подходящие значения

string[] arrayControl = new string[numbers]; 
ControlArray(arrayString, arrayControl, lengthControl);

void ControlArray(string[] startArray, string[] newArray, int lengthLimit) // метод для создания нового массива
{
    int temp = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= lengthLimit)
        {
            newArray[temp] = startArray[i];
            temp++;
        }
    }
}

string PrintArray(string[] array) // метод для вывода результата
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

Console.WriteLine("Элементы массива <= 3:");
Console.WriteLine($"{PrintArray(arrayControl)}");
Console.WriteLine();