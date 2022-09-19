int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,9);
}
int min = array[0];
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
    if(min > array[i])
    {
        min = array[i];
    } 
    if(max < array[i])
    {
        max = array[i];
    }
}
System.Console.WriteLine($"Максимальный элемент: {max}, Минимальный элемент: {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");