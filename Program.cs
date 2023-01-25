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