/*Задайте массив заполненный случайными
 положительными трёхзначными числами.
  Напишите программу, которая покажет количество
   чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[]FillArray (int length)
{
    int[]arr = new int [length];
    Random rnd = new Random();
    Console.Write("[");
    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        Console.Write(arr[i]+" ");
    }
    return arr;
}

int [] myArray = FillArray(4);
int sum = 0;
for(int i = 0; i < 4; i++)
{
    if(myArray[i] % 2 == 0)
    {
        sum += 1;
    }
    else
    {
        sum += 0;
    }
}
Console.Write("]-> " + sum);
