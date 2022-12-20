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


