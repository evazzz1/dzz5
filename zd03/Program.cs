//Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с
//наименьшей суммой элементов.

Random rand = new Random();
int x = rand.Next(1,5);
int y = rand.Next(1,5);
int [,] myArray = new int [x,y]; 
myArray = rndArray(myArray);
printArray(myArray);
findMinArray(myArray);

        
        
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
int maxSumOfArray (int [,] myArr)
{
    int maxSum = 0;
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            maxSum += myArr[i,j];
        }
    }
    return maxSum;
}
void findMinArray (int [,] myArr)
{    int sum = 0; int min = maxSumOfArray(myArr); int minstr = 0;
        for(int i = 0; i < myArr.GetLength(0); i++) 
        {
            for(int j = 0; j < myArr.GetLength(1); j++) 
            {
                sum = sum + myArr[i,j];
                //Console.WriteLine("summa " + sum);
            }
            Console.WriteLine("Сумма чисел на " + i + " строке равняется = " + sum);
            if(sum < min)
            {
                min = sum;
                minstr = i;
            }
            sum = 0;
            
        }
        Console.WriteLine("Минимальная сумма чисел: " + min + " находится на строке под номером " + minstr);

}
