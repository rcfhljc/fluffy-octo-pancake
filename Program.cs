//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
// double maxNumber = numbers[0];
// for (int i = 1; i < numbers.Length; i++)
// {
//     if(numbers[i]>maxNumber)
//     {
//         maxNumber=numbers[i];
//     }
// }
// double minNumber = numbers[0];
// for (int i = 1; i < numbers.Length; i++)
// {
//     if(numbers[i]<minNumber)
//     {
//         minNumber=numbers[i];
//     }
// }
// double difference =maxNumber - minNumber;
// Console.WriteLine("Разница между максимальным и минимальным элементами:{0}", difference);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] arr = new int[10];
// Random rand = new Random();
// for (int i = 0; i < 10; i++)
// {
//     arr[i] = rand.Next(1, 100);
// }
// int sum = 0;
// for (int i = 1; i <= 9; i += 2)
// {
//     sum += arr[i];
// }
// Console.WriteLine($"Сумма элементов на неченых позициях:{sum}");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// const int arraySize = 10;
// int[] array = GenerateRandomNumbers(arraySize);
// Console.WriteLine("Массив: " + string.Join(", ", array));
// int evenCount = CountEvenNumbers(array);

// static int[] GenerateRandomNumbers(int size)
// {
// Random random = new Random();
// int[] numbers = new int[size];
// for (int i = 0; i < size; i++)
// numbers[i] = (int)(random.NextDouble() * 999 + 1); 
// return numbers;
// }

// static int CountEvenNumbers(int[] nums)
// {
// return nums.Where(n => n % 2 == 0).ToList().Count;
// }
// Console.WriteLine($"Количество четных чисел = {evenCount}");
