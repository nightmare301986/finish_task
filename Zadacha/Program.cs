/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3.*/

string[] Prompt(string message)
{
    System.Console.Write($"{message}  >  ");
    string[] arr = System.Console.ReadLine().Split();
    return arr;
}

int count = 0;
string[] arr = Prompt("Введите элементы строки (через пробел): ");
string[] arr2 = new string[arr.Length];

void SecondArrayBelowFour(string[] arr, string[] arr2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
    if (count == 0)
    {
        arr2[0] = "Элементов в строке менее 3 символов нет";
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("Введенный (первоначальный) массив:");
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("Массив со строками длиной 3 или менее символа:");
SecondArrayBelowFour(arr, arr2);
PrintArray(arr2);
