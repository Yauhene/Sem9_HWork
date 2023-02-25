// Домашнее задание к семинару 9 от 22.02.2023
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
    Console.WriteLine("Представлены решения задач 64, 66 и 68");
    Console.WriteLine("Введите номер задачи(либо q/Q для выхода):");
    Console.WriteLine("--------------------------------------------------------------------");
    for(int i=1; i <=5; i++) Console.WriteLine();
    Console.WriteLine();
    Console.Write($"Ваш выбор? : {selNum}");
    
    selNum = Console.ReadLine();
        switch(selNum)
        {
            case "64":
            {
                Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                selNum = "";
                Console.Clear(); 
                Console.WriteLine();
                selNum = "";
                
                Task_64();
                
                selNum = "";
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();

                PauseString();
                            
                break;
            }

            case "66":
            {   
                 Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                selNum = "";
                Console.Clear(); 
                Console.WriteLine();
                selNum = "";
                 Task_66();

                PauseString();
                 Console.Clear();
                break;
            }
            
             case "68":
            {     
                Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                selNum = "";
                Console.Clear(); 
                Console.WriteLine();
                selNum = "";
                Task_68();

                //PauseString();
                 Console.Clear();
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



//==== Задача 66 =================================================================================================================
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Task_66()
{
    int m = IntInput("M");
    int n = IntInput("N");
    Console.WriteLine(NumbersSum(m,n));

}

//==== Задача 64 =================================================================================================================
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void Task_64()
{
    // Собрать строку с числами от n до 1
    int n = IntInput("N");
    Console.Clear();
    Console.WriteLine(NumbersRec(1, n)); 
    Console.WriteLine();
    Console.ReadLine();
}

void Task_68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    //m = 2, n = 3 -> A(m,n) = 9
    //m = 3, n = 2 -> A(m,n) = 29

int m = IntInput("m");
int n = IntInput("n");

int akk = AkkFunc(m, n);
Console.WriteLine(akk);
PauseString();


    Console.Clear();
    // Console.WriteLine(NumbersRec(1, n)); 
    // Console.WriteLine();
}

void PauseString()
{
    Console.WriteLine( "Для продолжения нажмите 'Ввод'...");
    Console.ReadLine();
}

string NumbersRec(int a, int b) // 
{
if (a <= b) return $"{b} " + NumbersRec(1, b-1);
else return String.Empty;
}

int NumbersSum(int n, int m) // 
{
int rev = 0;
if (n <= m) 
{
    return n + NumbersSum(n+1, m);
}
else 
{
    // rev = m;
    // m = n;
    // n = rev;

    return 0;//n + NumbersSum(n+1, m);
}
}

 // функция Аккермана
int AkkFunc(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkFunc(n - 1, 1);
    else
      return AkkFunc(n - 1, AkkFunc(n, m - 1));
}


   myTaskMenu();

