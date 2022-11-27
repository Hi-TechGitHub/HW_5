// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] ar = new int[4];
void FillArray(int[] arr)
{
    
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i += 1)
    {
        arr[i] = rnd.Next(-100, 100);
    }

}
void PrintArraySum (int[] array) 
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
         result += array[i];
    }
    Console.WriteLine(result);
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
PrintArraySum(ar);
//int result =+ arr[i];