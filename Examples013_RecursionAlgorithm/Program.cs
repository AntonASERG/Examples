// string[,] table = new string[2, 5];
// Srtring.Empty - константа для инициализации строк
//table [0,0]  [0,1]  [0,2]  [0,3]  [0,4]
//table [1,0]  [1,1]  [1,2]  [1,3]  [1,4]
// table[1,2] = "Слово";
// //цикл чтоб распечатать массив
// for (int rows = 0; rows < 2; rows++) // строки
// {
//     for (int colums = 0; colums < 5; colums++)// столбы
//     {
//         Console.WriteLine($"-{table[rows,colums]}-");//Экстраполяция
//     }
// }
void PrintArray(int[,] mat)//принимает как аргумент 2д таблицу
{
    for (int i = 0; i < mat.GetLength(0); i++) // строки (0) - "количество строк" вместо 3
    {
        for (int j = 0; j < mat.GetLength(0); j++)// столбы (1), заместо 4
        {
            Console.Write($"{mat[i, j]} ");//вывести элементы через пробел в строке
        }
        Console.WriteLine();// Применяется для цикла строк - что видеть новые
    }
}

void FillArray(int[,]mat)//заполняет рандомами
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
    for (int j = 0; j < mat.GetLength(1); j++) // 
    {
        mat[i,j] = new Random().Next(1,10);// [1,10) полуинтервал
    }
    }
}


int[,]matrix = new int[3,4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);


int[,] pic = new int[,];