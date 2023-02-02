/*// Задача 1: Написать программу, которая на вход принимает число и возводит в квадрат
Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine()!);

// // Математический метод
int sqr = number * number;
// //С библиотекой
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"Число {number} в квадрате равно: Математически {sqr}, с использованием библиотеки {sqr1}");


// Задача 2: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);

int num1 = -num;

while(num1 <= num){
    Console.Write($"{num1} ");
    num1++;
}
//Задача 3:  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (Math.Pow(number2, 2) == number1 ) {
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");}
    else
    {
        Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
   }
   */
//Задача 4: Определить день недели  
/*Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Понедельник");
if (num == 2) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Вторник");
if (num == 3) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Среда");
if (num == 4) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Четверг");
if (num == 5) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Пятница");
if (num == 6) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Суббота");
if (num == 7) 
    Console.WriteLine ($"Для числа {num} соотвествует день недели Воскресенье");*/

//Задача 5: Программа которая принимает трехзначное число и показывает последнюю цыфру этого числа

/*Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Последнее число числа {num} является { num % 10}");*/
//ДЗ
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
else
{
    Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
}*/
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;
if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);*/

// Задача 3: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
/*Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: нечетным");
}
else
{
    Console.WriteLine("Число " + num + "является: четным");
}*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
    {
    Console.Write(i + ", ");
    not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}*/


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*int number = new Random().Next(100,1000);
int result = (number/100)*10 + number % 10;
Console.WriteLine($"{number} -> {result}");*/

// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
 
 
/*int numb = new Random().Next(10, 100); // 34 
Console.WriteLine($"Выбранное число {numb}"); 
 
if(numb / 10 > numb % 10){ 
    Console.WriteLine($"максимальное  значение {numb / 10}"); 
} 
 Console.WriteLine($"максимальное значение {numb % 10}"); */
 
 
 
 
/* 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
  Если второе число не кратно числу первому, то программа выводит остаток от деления. 
 
34, 5 -> не кратно, остаток 4 
16, 4  -> кратно */ 
 
/*int nun_a = int.Parse(Console.ReadLine()!); 
 
int nun_b = int.Parse(Console.ReadLine()!); 
 
int result = nun_a % nun_b; 
 
Console.WriteLine($"результат: {result} = {nun_a} % {nun_b}"); 
 
if(nun_a % nun_b == 0){ 
    Console.WriteLine("Кратно"); 
} 
else{ 
    Console.WriteLine($"{result}"); 
} */
 
 
 
 
/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
 
14  ->  нет 
46  ->  нет 
161 ->  да */ 
 
/*Console.WriteLine("Введите число: "); 
int nun_C = int.Parse(Console.ReadLine()!); 
 
if(nun_C % 7 == 0 && nun_C % 23 == 0){ 
    Console.WriteLine($"Результат кратно"); 
} 
else{ 
    Console.WriteLine($"Результат не Кратен!"); 
} */
 
 
 
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
 
 
/*Console.WriteLine("Введите два числа: "); 
 
int number_A = int.Parse(Console.ReadLine()!); 
int number_B = int.Parse(Console.ReadLine()!); 
 
if(number_A * number_A == number_B || number_B * number_B == number_A){ 
    Console.WriteLine("Является"); 
} 
else{ 
    Console.WriteLine("НЕ является"); 
}*/

//ДОМАШНЕЕ ЗАДАНИЕ

// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

/*Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
Console.WriteLine("Вы ввели не трехзначное число! Повторите попытку");
}
else{
     num = num / 10 % 10;
            Console.WriteLine($"Вторая цифра введённого числа: {num}");
}*/


//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

/*Console.Write("Введи число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num1);
if (num2.Length > 2)
{
  Console.WriteLine("Третья цифра " + num2[2]);
}
else {
  Console.WriteLine("Третья цифра отсутсвует");
}*/

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

/*Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("Выходной");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("Ошибка");
  }
  else Console.WriteLine("Рабочий");
}

CheckingTheDayOfTheWeek(day);*/

// Задача № __ 
// Напишите программу, которая по заданному номеру четверти, показывает  
// диапазон возможных координат точек в этой четверти (x и y). 
 
/*System.Console.WriteLine("Введите номер четверти: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
 
if(number == 1) 
{ 
    System.Console.WriteLine("x > 0 && y > 0 (Первая четверть)"); 
} 
else if(number == 2) 
{ 
    System.Console.WriteLine("x < 0 && y >0 (Вторая четверть)"); 
} 
else if(number == 3) 
{ 
    System.Console.WriteLine("x < 0 && y < 0 (Третья четверть)"); 
} 
else if(number == 4) 
{ 
    System.Console.WriteLine("x > 0 && y < 0 (Четвертая четверть)"); 
} 
else 
{ 
    System.Console.WriteLine("Такой четверти не существует! ");
}*/

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

// ((x1 - x2)^2 + (y1-y2)^2)^(1/2)

/*System.Console.Write("Введите коррдинату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите коррдинату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите коордианту y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2)),4); 
System.Console.WriteLine($"Расстояние между двумя точками: {result}");*/


//Задача 4. Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.

/*System.Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= x; i++)
// {
// System.Console.WriteLine(Math.Pow(i, 2));
// }
int count = 1;
while(count <= x)
{
System.Console.Write(Math.Pow(count, 2)+" ");
count++;
}*/

//Домашнее задание
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

/*
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


/*int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);*/

//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*Console.Write("Введи число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

//--------------Методы-----------------
int GetSum (int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum = sum + i; // sum += i
    }
    return sum;
}*/

/*Console.WriteLine ("Type a number "); 
int A = int.Parse(Console.ReadLine()!); 
Console.Write($"Factorial is equal {GetFactorial(A)}"); 
 
int GetFactorial (int A) 
{ 
int Factorial = 1; 
for (int i = 1; i <= A; i++) 
{ 
    Factorial = Factorial * i; 
} 
return Factorial; 
}*/ 
 
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе 
 
/*Console.WriteLine ("Type a number "); 
int number = int.Parse (Console.ReadLine ()!); 
Console.Write($"The number of digits is {GetQuantity(number)}"); 
 
 
int GetQuantity (int A) 
{ 
    int Quantity = 0; 
    if (A == 0) return 1; 
    while (A > 0) 
    {Quantity = Quantity + 1; A = A / 10;} 
    return Quantity; 
} 
 
Console.WriteLine ("Type a number "); 
string Number = Console.ReadLine()!; 
Console.Write($"The number of digits is {GetQuantity2(Number)}"); 
 
int GetQuantity2 (string Number) 
{ 
    int Quantity2 = Number.Length; 
    return Quantity2; 
}*/ 
 
//Напишите программу, которая выводит массив из восьми элементов, 
//заполненный нулями и кдиницами в случайном порядке 
 
 
/*int[] Array = GetArray(8); 
Console.Write($"[{String.Join(";", Array)}]"); 
 
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(2); 
    } 
    return Array; 
}*/
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*int[] array = GetArray(12,-9,9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    if(el > 0){
        positiveSum += el;
    }
    else{
        negativeSum += el;
    }
}

Console.WriteLine($"Сумма положительных равна {positiveSum}, сумма отрицательных равна {negativeSum}");

// ------Метод------
int[] GetArray (int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/
//Напишите программу замены элементов массива:  
// положительные элементы замените на отрицательные 
 
/*int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i =0; i < size; i++) 
    { 
      Array[i] = new Random().Next(-10, 11);   
    } 
    return Array; 
} 
/*int[] Array = GetArray(10); 
Console.WriteLine($"[{String.Join(", ",Array)}]"); 
for (int i = 0; i < Array.Length; i++) 
{ 
    Array[i] = Array[i] * (-1); 
} 
Console.WriteLine($"[{String.Join(", ",Array)}]");*/ 
 
//  Задайте массив и напишите программу, 
// определяет, присутствует ли ли заданное число в массиве 
/*int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i =0; i < size; i++) 
    { 
      Array[i] = new Random().Next(-10, 11);   
    } 
    return Array; 
} 
 
int[] Array = GetArray(10); 
int Find = -5; 
Console.WriteLine($"[{String.Join(", ",Array)}]"); 
if (FindElement(Array, Find)) 
{ 
Console.WriteLine($"Данный элемент найден"); 
} 
else 
{ 
    Console.WriteLine($"Данный элемент не найден"); 
} 
 
bool FindElement (int[] Array, int Find) 
{ 
foreach (int ArrayEl in Array) 
{ 
    if (ArrayEl == Find) 
    { 
        return true; 
    } 
} 
return false; 
}*/
// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
 
/*int[] Array = GetArray(123); 
 
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i =0; i < size; i++) 
    { 
      Array[i] = new Random().Next(0, 1001);   
    } 
    return Array; 
} 
Console.WriteLine($"[{String.Join(", ",Array)}]"); 
int count = 0; 
for (int i = 0; i <= 122; i++) 
{ 
if (Array[i] >= 10 && Array[i] < 100) 
{ 
    count = count + 1;  
} 
} 
Console.WriteLine($"Количество цифр в данном диапазоне {count}");*/

// Массив из 12 элементов , случайные числа от -9 до 9. НАйти 
//суммы положительных и отрцательных элементов

/*int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positivSum = 0;
int negativSum = 0;

foreach(int el in array)
{
    if(el > 0)
    { positivSum += el;}
    else
    { negativSum += el;}
}

Console.WriteLine($"Сумма положительных равна {positivSum}, сумма отрицательных равна {negativSum}");

//---------------Methods-------------

int GetArray (int size, int minValue, int maxValue)
    {int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {res[i] = new Random().Next(minValue, maxValue +1);}

    return res;
}

// //Задача 32: Напишите программу замена элементов массива: 
// //положительные элементы замените на соответствующие отрицательные, и наоборот.

// //[-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] Array = GetArray(6);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
int[] Array2 =  Change(Array);
System.Console.WriteLine($"[{String.Join(",", Array2)}]");


//---------------Методы

int[] GetArray(int size)
{int[] res = new int[size];
       for(int i = 0; i < size; i++){
        res[i] = new Random().Next(-10, 10);
    }
    return res;
}

int[] Change(int[] Array)
{
    for(int item = 0; item < Array.Length; item++)

{
    Array[item] = -Array[item];
}
return Array;
}

//Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

int[] Array = GetArray(5);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
if(FindNumber(number, Array)) 
{Console.WriteLine($"Число {number} есть в массиве");}
else
{Console.WriteLine($"Число {number} отсутствует в массиве");}


//-------------------- Methods-----


int[] GetArray(int size)
{int[] res = new int[size];
       for(int i = 0; i < size; i++){
        res[i] = new Random().Next(20);
    }
    return res;
}

bool FindNumber(int number, int[] Array)
{
    foreach (int i in Array)
    {
        if(i==number)
        return true;
            }
    return false;
}

// int FindNumber(int number, int[] Array)
// {
//     for(int i = 0; i <Array.Length; i++)
//     {
//         if(Array[i]==number)
//         return i;
//             }
//     return false;
// }

//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
//элементов массива, значения которых лежат в отрезке [10,99].

int[] Array = GetArray(10);
Array[1] = 11;
Console.WriteLine($"[{String.Join(",", Array)}]");

Console.WriteLine($"Количество элементов от 10 до 99 в массиве равно {Quantity(Array)}");

//----------------Методы-----
int[] GetArray(int size)
{int[] res = new int[size];
       for(int i = 0; i < size; i++){
        res[i] = new Random().Next(0, 1001);
    }
    return res;
}

int Quantity(int[] Array)
{
    int count = 0;
    foreach (int el in Array)
    {
        if((10 <= el)&&(el  < 100))
        {count++;}
    }
    return count;
}*/
//Домашнее задание
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива  
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);*/
//Домашнее задание
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*Console.Clear();
Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Clear();
Console.WriteLine($"\nЗадача 36. Сумма элементов, стоящих на нечётных позициях:\n");
Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine($"\nЗадача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");*/

/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] array = GetArray(5, 0, 20);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] resultArray = ReverseArray2(array);
Console.WriteLine($"[{String.Join(",", resultArray)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(",", array)}]");


// ------Методы------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length/2; i++){
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*Console.WriteLine("Введите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3: ");
int C = int.Parse(Console.ReadLine()!);

if((A > 0 && B > 0 && C > 0) || (A < B + C && B < A + C && C < A + B)) Console.WriteLine("Такой треугольник возможен");
else Console.WriteLine("Такой треугольник невозможен");*/

// Опрделить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

/*Console.WriteLine("Введите шестизначное число: ");
string X = (Console.ReadLine()!);
int size = X.Length;
if(size != 6) System.Console.WriteLine("Число не шестизначное");
else Check(X);


//-------------

void Check(string X)

{
int Sum1 = 0;
int Sum2 = 0;

int i = 0;
while(i<size/2)
{Sum1 += Convert.ToInt32(Convert.ToString(X[i]));
i++;}
while(i<size)
{Sum2 += Convert.ToInt32(Convert.ToString(X[i]));
i++;}
if(Sum1 == Sum2) {System.Console.WriteLine("Это счастливое число");}
else {System.Console.WriteLine("Это не счастливое число");}
}


//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
//Числа Фибоначчи — числовая последовательность, каждый элемент которой равен сумме двух предыдущих.

Console.WriteLine("Введите число N: ");
int size = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"[{String.Join(",",Fibonacci(size))}]");


//-------------------------
int[] Fibonacci(int size)
{
    int[] res = new int[size];

    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < size; i++)
    {
    res[i] = res[i-1] + res[i-2];
    }
    return res;
}*/

//Домашнее задание

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/*Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");*/

//Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке
// от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

/*int[] arr = new int[6];
Random r = new Random();

int temp;
Console.WriteLine(" ");
for (int i = 0; i < arr.Length; i++)
{
  arr[i] = r.Next(6);
  Console.Write(arr[i] + " ");

}

Console.WriteLine("\n\nСортируем от меньшего к большему\n");
for (int i = 0; i < arr.Length; i++)
{
  for (int j = 0; j < arr.Length; j++)
  {
    if (arr[i] < arr[j])
    {
      temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }
  }

}
Console.WriteLine("Отсортированный массив");
for (int i = 0; i < arr.Length; i++)
{
  Console.Write (arr[i] + (" "));

}
Console.ReadLine();*/

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);



// -------------------Методы---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/
/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
*/
/*
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
*/



//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void ArrayCow(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if (i % 2 ==0 && j % 2 ==0 )
                array[i,j] *= array[i,j];
        }
    }
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
ArrayCow(array);
PrintArray(array);
*/

//Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int ArrayCow(int[,] array){
    int sum =0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if (i == j)
                sum += array[i,j];
        }
    }
    return sum;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(ArrayCow(array));
*/
// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле:  
// Aₘₙ = m+n. Выведите полученный массив на экран. 
 
/*int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++){ 
    for(int j = 0; j < n; j++){ 
    result[i,j] = i + j; 
        } 
    } 
    return result; 
} 
 
void PrintArray(int[,] array){ 
    for(int i = 0; i < array.GetLength(0); i++){ 
        for(int j = 0; j < array.GetLength(1); j++){ 
            Console.Write($"{array[i,j]} "); 
        } 
        Console.WriteLine(); 
    } 
}*/ 
 
// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты. 
 
/*Console.Write("Введите количество строк: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array); 
Console.WriteLine(); 
PrintArray(GetArray2(array)); 
 
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++) 
    { 
    for(int j = 0; j < n; j++) 
    { 
    result[i,j] = i + j; 
    } 
    } 
    return result; 
} 
 
void PrintArray(int[,] array){ 
    for(int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    Console.Write($"{array[i,j]} "); 
    } 
        Console.WriteLine(); 
    } 
} 
 
int[,] GetArray2(int[,] array) 
{ 
   // int[,] Array2 = new int[rows,columns]; 
    for(int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    if (i % 2 == 0 && j % 2 == 0)  
    array[i,j] = array[i,j] * array[i,j]; 
    } 
    } 
    return array; 
}*/ 
//Задача 51:** Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д. 
/*Console.Write("Введите количество строк: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array); 
Console.WriteLine($" The sum is equal to {GetSumOfElements(array)}"); 
 
 
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++) 
    { 
    for(int j = 0; j < n; j++) 
    { 
    result[i,j] = i + j; 
    } 
    } 
    return result; 
} 
 
void PrintArray(int[,] array){ 
    for(int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    Console.Write($"{array[i,j]} "); 
    } 
        Console.WriteLine(); 
    } 
} 
 
int GetSumOfElements(int[,] array) 
{ 
    int sum = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    if (i == j)  
    sum = sum + array[i,j]; 
    } 
    } 
    return sum; 
}*/
//Домашнее задание
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}*/
/*Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
/*int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// Заполнение массива рандомными числами от 1 до 9
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



/*Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();*/
//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2

/*int[,] array = GetArray(3,4,0,10);
PrintArray(array);

System.Console.WriteLine();


System.Console.WriteLine(check);
// Change(array);
// PrintArray(array);
// ------------------
int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] array2 = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array2;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}


void Change(int[,] array)
{
    for(int i =0; i <array.GetLength(1);i++)
       {

        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;
       }
}


// Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7


int[,] array = GetArray(4,4,0,10);
PrintArray(array);

System.Console.WriteLine();

bool check = Check(array);
System.Console.WriteLine(check);

int[,] changedArray = Change(array);

if(check) PrintArray(changedArray);
else System.Console.WriteLine("Это невозможно");

// Change(array);
// PrintArray(array);
// ------------------

bool Check(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] array2 = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array2;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

int[,] Change(int[,] array)
{
    int[,] changedArray = new int[array.GetLength(0),array.GetLength(1)];
    for(int i = 0; i <array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            changedArray[i,j] = array[j,i];
        }
    }
return changedArray;
}*/
// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
// if (i == indexes[0]) continue;

/*int[,] array = GetArray(4,4,0,10);
PrintArray(array);
System.Console.WriteLine();

PrintArray(ChangedArray(array, minIndex(array)));


int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] array2 = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array2;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        { Console.Write($"{collection[i, j]} "); }
        Console.WriteLine();
    }
}

int[] minIndex (int[,] array)
{
    int min = array[0,0];
    int[] index = new int[] {0,0};
    for(int i=0; i< array.GetLength(0); i++)
        {
            for(int j=0; j< array.GetLength(1); j++)
            {
                if(array[i,j]<min)
                {
                    min = array[i,j];
                    index[0] = i;
                    index[1] = j;
                }
            }
        }
        return index;
}

int[,] ChangedArray (int[,] array, int[] index)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int k = 0;
    int l = 0;
    for(int i=0; i< array.GetLength(0); i++)
        {
            if(i == index[0]) continue;
            
            for(int j=0; j< array.GetLength(1); j++)
            {
                if(j == index[1]) continue;
                newArray[k,l] = array[i,j];
                l++;
            }
            l=0; 
            k++;
         
        }
        return newArray;
}*/
//ДОМАШНЕЕ ЗАДАНИЕ
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);


// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);


// Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}*/
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}*/
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
/*int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}*/
/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
/*int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);


//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/
/*
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введи число: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(1,N));

// ------------------Метод------------------
string PrintNumbers(int start, int end){
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}


Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"

Eka Eka, [30.01.2023 12:39]
//Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
 
// N = 5 -> "1, 2, 3, 4, 5" 
 
// N = 6 -> "1, 2, 3, 4, 5, 6" 
 
/*Console.Write("Введи число: "); 
int N  = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine(PrintNumbers(1,N)); 
 
// ------------------Метод------------------ 
string PrintNumbers(int start, int end) 
{ 
    if(start == end) return start.ToString(); 
    return (start + " " + PrintNumbers(start + 1, end)); 
}*/ 
 
 
//Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
 
//M = 1; N = 5. -> "1, 2, 3, 4, 5" 
// M = 4; N = 8. -> "4, 5, 6, 7, 8" 
 
/*Console.WriteLine("Введите число  N"); 
int N = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите число  M"); 
int M = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine(PrintNumbers(N,M)); 
 
 
string PrintNumbers(int start, int end) 
{ 
    if(start == end) return start.ToString(); 
    return (start + " " + PrintNumbers(start + 1, end)); 
}*/ 
 
// Принять на вход число, вернуть сумму его цифр 
 
/*Console.WriteLine("Введите число  N"); 
int N = int.Parse(Console.ReadLine()!); 
Console.WriteLine(NumberFiguresSum(N)); 
 
int NumberFiguresSum(int N) 
{ 
    if(N == 0) return 0; 
    return (N % 10 + NumberFiguresSum(N / 10)); 
}*/ 
 
// Возведите число А в степень Б с помощью рекурсии 
 
/*Console.WriteLine("Введите число A"); 
int A = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine("Введите число B"); 
int B = int.Parse(Console.ReadLine()!); 
 
Console.WriteLine(PoweredBy(A,B)); 
 
// --------------method------------------- 
 
int PoweredBy(int A, int 
{ 
    if(B == 0) return 1; 
    if(B == 1) return A; 
    return (A * PoweredBy(A, B - 1)); 
}*/
//ДОМАШНЕЕ ЗАДАНИЕ
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Clear();
Console.WriteLine($"Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

/*Console.Clear();
Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/