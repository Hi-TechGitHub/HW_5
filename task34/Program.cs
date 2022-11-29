// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] ar = new int[3];
void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i += 1)
    {
        array[i] = rnd.Next(99, 1000);
    }
}
int IfArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
    
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i += 1)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
FillArray(ar);
PrintArray(ar);
int result = IfArray(ar);
Console.WriteLine(result);