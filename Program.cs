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


// Console.WriteLine("Введите размерность массива: ");
// int ArrayLenght = Convert.ToInt32(Console.ReadLine());
// Random rnd = new Random();
// int[] Array = new int[ArrayLenght];
// int SumOfArray = 0;
// for (int i = 0; i < ArrayLenght; i++)
// {
//     Array[i] = rnd.Next(1, 35);
// }
// Console.WriteLine("Массив - ");
// foreach (var item in Array)
// {
//     Console.WriteLine($"{item}");
// }
// for (int i = 1; i < Array.Length; i += 2)
// {
//     SumOfArray+= Array[i];
// }
// Console.WriteLine("Сумма нечётных позиций в массиве - {0}", SumOfArray);

// Console.WriteLine("Введите размерность массива: ");
// int ArrayLenght = Convert.ToInt32(Console.ReadLine());
// Random rnd = new Random();
// double[] Array = new double[ArrayLenght];
// for (int i = 0; i < ArrayLenght; i++)
// {
//     Array[i] = rnd.NextDouble();
// }
// foreach (var item in Array)
// {
//     Console.WriteLine($"{item}");
// }
// Console.WriteLine($"Разница в массиве между самым большим и самым маленьким - {Difference(Array)}");
// double Difference(double[] Array)
// {
//     double max = Array[0];
//     double min = Array[0];
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] > max)
//         {
//             max = Array[i];
//         }
//         else if (Array[i] < min)
//         {
//             min = Array[i];
//         }
//     }
//     double difference = max-min;
//     return difference;
// }