Console.WriteLine("Введите размерность массива: ");
int ArrayLenght = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] Array = new int[ArrayLenght];
for (int i = 0; i < ArrayLenght; i++)
{
    Array[i] = rnd.Next(100,999);
}
foreach (var item in Array)
{
   Console.WriteLine($"{item}"); 
}
Console.WriteLine($"Количество чётных чисел в массиве - {CountOfEvenNumbers(Array)} ");

int CountOfEvenNumbers(int[] Array)
{
    int count = 0;
    foreach (var item in Array)
    {
        if(item%2==0)
        {
            count++;
        }
    }
    return count;
}
