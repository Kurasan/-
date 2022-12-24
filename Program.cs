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