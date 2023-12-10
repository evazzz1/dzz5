//Задача 1: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.


Console.WriteLine("Введите x:");
string xstr = Console.ReadLine();
int xpoint = checkIfNum(xstr); //(x,y) значение х
Console.WriteLine("Введите y:");
string ystr = Console.ReadLine();
int ypoint = checkIfNum(ystr); //(x,y) значение y
Console.WriteLine();


int x = new Random().Next(1,5);
int y = new Random().Next(1,5);
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
            myArr[i,j] = new Random().Next(1,10);
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
    
int checkArray(int [,] myArr, int x, int y)
{
    if(x >= 0 && x < myArr.GetLength(0) && y >= 0 && y < myArr.GetLength(1))
    {
        return myArr[x,y];
    }
    else
    {
        Console.WriteLine("Не существует элемента на данной позиции. Попробуйте ввести координаты заново");
        return checkArray(myArr, checkIfNum (Console.ReadLine()), checkIfNum (Console.ReadLine()));
    }
}

int checkIfNum (string text)
{
    int num;
    bool isNum = Int32.TryParse(text, out num);
    if (isNum)
    {
        return Convert.ToInt32(text);
    }
    else 
    {
        Console.WriteLine("try again");
        text = Console.ReadLine();
        return checkIfNum(text);
    }
}