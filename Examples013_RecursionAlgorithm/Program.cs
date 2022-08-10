// // string[,] table = new string[2, 5];
// // Srtring.Empty - константа для инициализации строк
// //table [0,0]  [0,1]  [0,2]  [0,3]  [0,4]
// //table [1,0]  [1,1]  [1,2]  [1,3]  [1,4]
// // table[1,2] = "Слово";
// // //цикл чтоб распечатать массив
// // for (int rows = 0; rows < 2; rows++) // строки
// // {
// //     for (int colums = 0; colums < 5; colums++)// столбы
// //     {
// //         Console.WriteLine($"-{table[rows,colums]}-");//Экстраполяция
// //     }
// // }
// void PrintArray(int[,] mat)//принимает как аргумент 2д таблицу
// {
//     for (int i = 0; i < mat.GetLength(0); i++) // строки (0) - "количество строк" вместо 3
//     {
//         for (int j = 0; j < mat.GetLength(0); j++)// столбы (1), заместо 4
//         {
//             Console.Write($"{mat[i, j]} ");//вывести элементы через пробел в строке
//         }
//         Console.WriteLine();// Применяется для цикла строк - что видеть новые
//     }
// }

// void FillArray(int[,]mat)//заполняет рандомами
// {
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//     for (int j = 0; j < mat.GetLength(1); j++) // 
//     {
//         mat[i,j] = new Random().Next(1,10);// [1,10) полуинтервал
//     }
//     }
// }


// int[,]matrix = new int[3,4];
// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);


// // 
//  double Factorial (int n) // Метод ФАКТОРИАЛА
//  {
//     //1!=1
//     //0!=1 
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
//  }

//  for (int i = 1; i < 40; i++)// цикл значения от 1 до 39
//  {
//     Console.WriteLine($"{i}! = {Factorial(i)}");// переполнение цикла 
//  }

//ФИБОНАЧИ
// f(1)=1
// f(2)=1
//f(n) = f(n-1) +f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else  return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 40; i++)// цикл значения от 1 до 39
{
    Console.WriteLine($"f{i}!) = {Fibonacci(i)}");
}