// Console.WriteLine("Введите размерность массива: ");
// int ArrayLenght = Convert.ToInt32(Console.ReadLine());
// Random rnd = new Random();
// int[] Array = new int[ArrayLenght];
// for (int i = 0; i < ArrayLenght; i++)
// {
//     Array[i] = rnd.Next(100,999);
// }
// foreach (var item in Array)
// {
//    Console.WriteLine($"{item}"); 
// }
// Console.WriteLine($"Количество чётных чисел в массиве - {CountOfEvenNumbers(Array)} ");

// int CountOfEvenNumbers(int[] Array)
// {
//     int count = 0;
//     foreach (var item in Array)
//     {
//         if(item%2==0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


Console.WriteLine("Введите размерность массива: ");
int ArrayLenght = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] Array = new int[ArrayLenght];
int SumOfArray = 0;
for (int i = 0; i < ArrayLenght; i++)
{
    Array[i] = rnd.Next(1, 35);
}
Console.WriteLine("Массив - ");
foreach (var item in Array)
{
    Console.WriteLine($"{item}");
}
for (int i = 1; i < Array.Length; i += 2)
{
    SumOfArray+= Array[i];
}
Console.WriteLine("Сумма нечётных позиций в массиве - {0}", SumOfArray);