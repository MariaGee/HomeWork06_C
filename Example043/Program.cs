//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] matrix = new double[2,2];

void EnteringNumbers(double[,] array)
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Введите, пожалуйста, коэффициенты k и b для {i+1} функции (y = kx + b)");
        for (int j = 0; j < 2; j++)
        {
            if (j == 0)
            {
                Console.WriteLine($"Введите коэффициент k");
            }
            else 
            {
                Console.WriteLine($"Введите коэффициент b");
            }
            array[i,j] = Convert.ToDouble(Console.ReadLine());
        }
    }
}

void ArrayOutput(double[,] matr)
{
    for(int n = 0; n < 2; n++)
    {
        for (int m = 0; m < 2; m++)
        {
            Console.Write($"{matr[n,m]}  ");
        }
        Console.WriteLine();
    }
}

double[] Solution (double[,] arr)
{
    double[] res = new double [2];
    res[0] = ((arr[1,1] - arr[0,1]) / (arr[0,0] - arr[1,0]));
    res[1] = arr[0,0] * res[0] + arr[0,1];
    return res;
}

EnteringNumbers(matrix);
Console.WriteLine("Был задан следующий массив коэффициентов:");
ArrayOutput(matrix);
double[] result = Solution(matrix);
if (matrix[0,0] == matrix[1,0]) Console.WriteLine("Прямые параллельны");
else Console.WriteLine($"Точка пересения прямых: {result[0]}; {result[1]}");
