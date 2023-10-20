int [] GenerateArray(int sizeArray, int leftRange, int rightRange)
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
void Array(int[]array)
{
int Count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
Count++;
Console.WriteLine($"всего {array.Length} чисел, {Count} из них чётные");
}

int[] array=GenerateArray(7,100,999);
PrintArray(array);

Array(array);
//PrintArray(array);