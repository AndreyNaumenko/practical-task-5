int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
}
int unevenSum = 0;
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
    if(i % 2 > 0)
    {
        unevenSum = unevenSum + array[i];
    }
}
System.Console.Write("Cумма элементов, стоящих на нечётных позициях: " + unevenSum);