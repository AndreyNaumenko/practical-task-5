//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
}
int count = array.Length;
int position = 0;
int evenNumbers = 0;
while (position < count)
{
    System.Console.Write(array[position] + " ");
    if(array[position] % 2 == 0)
    {
        evenNumbers = evenNumbers + 1;
    }
    position++;
}
System.Console.Write("Количество чётных чисел в массиве: " + evenNumbers);