﻿// Домашнее задание к семинару 9 от 22.02.2023
//=====================================================================================================================
// Функция консольного меню

void myTaskMenu()
{
 bool exitNah=true; // переменная, обращение которой в true дает команду на выход из программы
    string selNum = "";

    Console.WriteLine("Welcome to HELL !!!");

    while (exitNah == true)
    {
    Console.Clear(); 
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine("Представлены решения задач 47, 50 и 52");
    Console.WriteLine("Введите номер задачи(либо q/Q для выхода):");
    Console.WriteLine("--------------------------------------------------------------------");
    for(int i=1; i <=5; i++) Console.WriteLine();
    Console.WriteLine();
    Console.Write($"Ваш выбор? : {selNum}");
    
    selNum = Console.ReadLine();
        switch(selNum)
        {
            case "47":
            {
                Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                
                Task_47();
                
                selNum = "";
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
                            
                break;
            }

            case "50":
            {    Console.WriteLine($"Выбрано : Задача {selNum}");
                Task_50();

                selNum = "";

                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }
            
             case "52":
            {    Console.WriteLine($"Выбрано : Задача {selNum}");
                Task_52();

                selNum = "";

                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }

            case "q":
            {
                exitNah = false;
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }

            case "Q":
            {
                exitNah = false;
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }
            default:
            {
                Console.WriteLine("Попробуйте еще раз. Есть шанс исправиться.");
                Console.WriteLine();
                Console.WriteLine();
                selNum = "";

                break;
            }
                
            
        }
    }
}

//=====================================================================================================================
// Функция принимает число из консоли и обходит ошибку ввода
int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое
                             // зело ругаеццо при косячном вводе
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}

//=====================================================================================================================
// Функция создает двумерный массив случайных вещественных чисел с заданным размером

double[,] makeArray(int rowNum, int colNum)
{
    double[,] tdArray = new double[rowNum, colNum];
    Random rnd = new Random();
    for (int i = 0; i <= rowNum-1; i++)
    {
        for (int j=0; j <= colNum-1; j++)
        {
            tdArray[i,j] = Math.Round(rnd.NextDouble()+rnd.Next(-20,20), 1); //result[i, j] = Math.Round(rand.NextDouble() + 10, 2);
        }
    }
    return tdArray;
}

//=====================================================================================================================
// Функция выводит на экран содержимое двумерного массива
void printArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string stringRes;
    for (int i = 0; i <= rows-1; i++)
    {
        for (int j = 0; j <= columns-1; j++)
        {
            
            stringRes = string.Format("{0:f2}", arr[i,j]);
            Console.Write(stringRes + "  ");
        }    
        Console.WriteLine();
    }

    for(int i=1; i<3; i++) Console.WriteLine();
   
}



//==== Задача 47 =================================================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task_47()
{
    double[,] array = makeArray(3, 4);
    printArray(array);

    PauseString();
}

//==== Задача 50 =================================================================================================================
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. 
void Task_50()
{
    int rCount = 3;
    int cCount = 4;
    double[,] array = makeArray(rCount, cCount);
    int rowNumber;
    int columnNumber;
    int indexNum=0;
    bool onceMore=true;

    Console.Clear();


    Console.WriteLine("Представлен массив размером 3 х 4.");
    
    printArray(array);
    Console.WriteLine("Введите индекс элемента как двузначное число, первая цифра - строка, вторая - колонка");
    indexNum = IntInput("");
    while (indexNum<10 && indexNum>=100)
    {
        Console.WriteLine($"indexNum = {indexNum}");
        Console.WriteLine($"Введенное число {indexNum} не является двузначным.");
        Console.WriteLine("Некрасиво вышло. Еще разок?");
    }

    rowNumber = indexNum / 10;
    columnNumber = indexNum % 10;
    
    if (rowNumber>rCount || columnNumber>cCount)
    {
        Console.WriteLine("Да нет тут такого индекса");
    }
    else
    {
        printArray(array);
        Console.WriteLine();
        Console.WriteLine($" Значение элемента массива в строке {rowNumber} и колонке {columnNumber} равно {array[rowNumber-1,columnNumber-1]}");
        Console.WriteLine();
    }

    PauseString();
}

void Task_52()
{
    int rCount = 3;
    int cCount = 3;
    double sumInColumn;
    double[,] array = makeArray(rCount, cCount);
    Console.WriteLine();
    printArray(array);
    for (int j = 0; j < cCount; j++)
    {
        sumInColumn = 0;

        for (int i = 0; i < rCount; i++)
        {
            sumInColumn = sumInColumn + array[i,j];
        }
        string stringRes = string.Format("{0:f2}", sumInColumn/rCount);
        
        Console.WriteLine("Среднее арифметическое колонки " + (j+1) + " равно " + stringRes);
    }
     PauseString();
}

void PauseString()
{
    Console.WriteLine( "Для продолжения нажмите 'Ввод'...");
    Console.ReadLine();
}

    myTaskMenu();

