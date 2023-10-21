//Задача 36: Задайте одномерный массив, заполненный случайными числами.
 //Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
{
    int[]newArray=new int[sizeArray];
    Random rand=new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
       newArray[i]=rand.Next(leftRange,rightRange+1); 
    }
    return newArray;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
void SumArray(int[]array)
{

int count=0;

for (int i = 0; i < array.Length; i+=2)
count+=array[i];

Console.WriteLine($"всего {array.Length} чисел");
Console.WriteLine($"сумма элементов на не четных позициях {count} ");
}

int[] array=GenerateArray(5,1,10);
PrintArray(array);

SumArray(array);