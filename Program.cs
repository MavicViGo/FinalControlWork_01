/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
int FillBassicArray(string[] matrix)
{
int j=0;    
for (int i=0; i < matrix.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        matrix[i] = Console.ReadLine()!;
        if (matrix[i].Length <= 3)
        j++;
        //Console.WriteLine($"{matrix[i].Length}");
    }
    return j;
}


void FillResultArray(string[] matrix1, string[] matrix2)
{
int j = 0;    
for (int i=0; i < matrix1.Length; i++)
    {
        if (matrix1[i].Length <= 3)
        {
            matrix2[j] = matrix1[i];
            j++;
        }
    }
}


void PrintArray(string[] matrix)
{
for (int i=0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]}, ");
    }
}


Console.Clear();
Console.Write("Введите желаемый размер строкового массива, от 1 до 10 : ");
int n =  int.Parse(Console.ReadLine()!);
while (n < 1 || n > 10)
{
    Console.WriteLine("Вы ошиблись!\nВведите значание от 1 до 10");
}
string[] array = new string[n];
int m = FillBassicArray(array);
string[] arrayResult = new string[m];
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
FillResultArray(array, arrayResult);
Console.WriteLine("Результирующий массив: ");
PrintArray(arrayResult);