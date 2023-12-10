//Задача 4*(не обязательная): Задайте двумерный массив
//из целых чисел. Напишите программу, которая удалит
//строку и столбец, на пересечении которых расположен
//наименьший элемент массива. Под удалением
//понимается создание нового двумерного массива без
//строки и столбца

Random rand = new Random();
int x = rand.Next(2,5);
int y = rand.Next(2,5);
int [,] myArray = new int [x,y]; 
int [,] newArray = new int [x-1, y-1];
myArray = rndArray(myArray);
printArray(myArray);

        
        
int [,] rndArray(int [,] myArr)
{
    int sumOfArray = 0;
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            myArr[i,j] = rand.Next(1,10);
            sumOfArray += myArr[i,j];
        }
    }
    return myArr;
}
void printArray(int [,] myArr)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            Console.Write(myArr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

