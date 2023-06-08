// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
//Console.Write("Введите количество элементов массива: ");
//int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
//string[] array1 = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)

string[] arrFirst = new string[5] 
{"Hello", "2", "world", ":-)", "computer science"};//создание массива типа string

string[] arrSecond = new string[arrFirst.Length]; //создание второго измененного массива размер равного с первым
Console.WriteLine("Первоначальный массив");
PrintArray(arrFirst);
SecondArray(arrFirst, arrSecond);
Console.WriteLine();
Console.WriteLine("Итоговый массив");
PrintArray(arrSecond);

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;// создание счетчика для цикла
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)//проверка i-го элемента на колво символ равной или меньше 3
        {
        array2[count] = array1[i];// если i-й элемент первого масиива равен или меньше 3х, то перезависывается во второй массив
        count++; //увеличение счетчик для цикла массива 2
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

