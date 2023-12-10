﻿
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
Console.WriteLine();
newArray = getNewArray(newArray, myArray);
printArray(newArray);       
        
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


int [,] getNewArray (int [,] newArray,int [,] myArray)
{
    int min = myArray[0,0];
    int minX = 0; int minY = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if(myArray[i,j] < min)
            {
                min = myArray[i,j];
                minX = i;
                minY = j;
            }
        }
       
    }
    Console.WriteLine("Минимальное число: " + min + " на координатах: x = " + minX + ", y = " + minY);

    for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[minX, j] = 0;
            }
        myArray[i, minY] = 0;
        }
    printArray(myArray); //решила оставить вам некоторые пояснения, в общем, я не придумала как сразу переставить элементы в другой
                        //поэтому я заменила на нули пересечения, и решила уже отсюда убирать нули. намудрила я конечно, надеюсь вам будет понятно..

    int newRow = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
        {
            int newColumn = 0;
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if (myArray[i, j] != 0)
                {
                    newArray[newRow, newColumn] = myArray[i, j];
                    newColumn++;
                }
            }

            if (newColumn > 0)
            {
                newRow++;
            }
        }

return newArray; 
}

