// Посчитать сумму элементов побочной диагонали матрицы.
Console.Clear();
Console.WriteLine("Посчитать сумму элементов побочной диагонали матрицы");
Console.Write("Введите размер квадратной матрицы:");
int size = int.Parse(Console.ReadLine()?? "0");

int[,] matrix = new int[size,size];
int sum = 0; 
var rnd = new Random();

for(int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
        matrix[i,j] = rnd.Next(0,6);
    sum +=matrix[i,size-i-1];    
}

Console.WriteLine($"Квадратная матрица {size}x{size}");
for (int i = 0; i < size; i++)
{ 
    for (int j = 0; j < size; j++)
        Console.Write($"{matrix[i,j]}");
    Console.WriteLine();
}
Console.WriteLine($"Сумма побочной диагонали матрицы равна {sum}");