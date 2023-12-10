//Задача 2: Задайте двумерный массив. Напишите
//программу, которая поменяет местами первую и
//последнюю строку массива.


Random rand = new Random();
int x = rand.Next(1,5);
int y = rand.Next(1,5);
int [,] myArray = new int [x,y]; 
myArray = rndArray(myArray);
printArray(myArray);
int positioonOfPoint = checkArray(myArray, xpoint, ypoint);
Console.WriteLine("Значение элемента по координатам = "+ positioonOfPoint);
        
        
int [,] rndArray(int [,] myArr)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            myArr[i,j] = rand.Next(1,10);
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
    
