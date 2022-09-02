//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 3

Console.WriteLine("Пожалуйста, введите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());

int[] matrix = new int[M];
for (int i = 0; i < matrix.Length; i++)
{
    Console.WriteLine($"Пожалуйста, введите {i + 1} число");
    matrix[i] = Convert.ToInt32(Console.ReadLine());
}

int countingPositiveNumbers (int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0) count++;
    }
    return count;
}

Console.WriteLine($"В введеном массиве {countingPositiveNumbers(matrix)} положительных чисел(а)");