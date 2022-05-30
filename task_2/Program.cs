// 2.//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] matrix = new int[4, 4]; 
for(int row = 0; row < matrix.GetLength(0); row++)  
{ 
    for(int column = 0; column < matrix.GetLength(1); column++) 
    { 
        matrix[row, column] = new Random().Next(1,4); 
    } 
}  
for(int row = 0; row < matrix.GetLength(0); row++)  
{ 
    for(int column = 0; column < matrix.GetLength(1); column++) 
    { 
        Console.Write(matrix[row, column] + " ");    
 
    }  
    Console.WriteLine(); 
}  
 
int sum1 = 0; 
for(int column = 0; column < matrix.GetLength(1); column++) 
 
{ 
    for(int row = 0; row < matrix.GetLength(0); row++)  
    { 
        sum1 = sum1 + matrix[row, column];    
    } Console.WriteLine($"{(double)sum1/4} "); 
      sum1 = 0; 
     
}  Console.WriteLine();



// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
double [] MediumOfColumn(int[,] matr)
{
    double [] medium = new double [matr.GetLength(1)];
    for (int i=0; i<matr.GetLength(1); i++)
    {    
        double sum = 0;
        for(int j=0; j<matr.GetLength(0); j++)
        {
            sum = sum + matr[j,i];                        
        }
        medium [i] = sum / matr.GetLength(0);
    }
    return medium;
}

void PrintResult(double[] array)
{
    for(int i =0; i<array.GetLength(0); i++)
        Console.Write($"{array[i]} ");
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()?? "");
int[,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Средние по столбцам:");

PrintResult(MediumOfColumn(matrix));

// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
double MeanAriphm(int[,] matr, int column)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
        sum = sum + matr[i, column];
    return sum / matr.GetLength(0);
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Полученный массив: ");
PrintArray(matrix);
for (int j = 0; j < k; j++)
    Console.WriteLine($"Среднее арифметическое столбца {j + 1} = {MeanAriphm(matrix, j)}");