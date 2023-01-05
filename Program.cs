﻿using System;
using System.Globalization;


namespace ConsoleAppSimpleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, type a number of task: ");
            int numberTask = int.Parse(Console.ReadLine());

            if (numberTask == 1)
            {
                FirstTask();
            }
            else if (numberTask == 2)
            {
                SecondTask();
            }
            else if (numberTask == 3)
            {
                ThreeTask();
            }
            else if (numberTask == 4)
            {
                FourTask();
            }
            else if (numberTask == 5)
            {
                FiveTask();
            }
            else if (numberTask == 6)
            {
                SixTask();
            }
            else if (numberTask == 7)
            {
                SevenTask(9, 8);
            }
            else if (numberTask == 8)
            {
                EightTask();
            }
            else if (numberTask == 9)
            {
                NineTask();
            }
            else if (numberTask == 10)
            {
                TenTask();
            }
            else if (numberTask == 11)
            {
                ElevenTask();
            }
            else if (numberTask == 12)
            {
                TvelfeTask();
            }
            else if (numberTask == 13)
            {
                ThreeteenTask();
            }
            else if (numberTask == 14)
            {
                GlovesOfTask();
            }
            else if (numberTask == 15)
            {
                ImportantWordParse();
            }
            else if (numberTask == 16)
            {
                SixteenTask();
            }
            else if (numberTask == 17)
            {
                SeventeenTask();
            }
            else if (numberTask == 18)
            {
                Eighteen();
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Записать трехзначное число в обратном порядке
        /// </summary>
        static void FirstTask()
        {
            Console.Write("Введите любое трехзначное число: ");
            int anyNum = Convert.ToInt32(Console.ReadLine());

            int a, b, c;

            a = anyNum / 100;
            c = anyNum % 10;
            b = anyNum / 10;
            b %= 10;
            Console.WriteLine("Получилось: {0}{1}{2}", c, b, a);
        }
        /// <summary>
        /// написать программу, которая спрашивает у пользователя Имя и сколько ему лет и выводит на экран сообщение
        /// </summary>
        static void SecondTask()
        {
            Console.Write("How many years are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("What`s your name? ");
            string name = Console.ReadLine();

            if (name != null && age >= 0)
            {
                Console.WriteLine($"His name is " + name + " and age -" + age);
            }
            else
            {
                Console.WriteLine("He isn`t talk your name and age");
            }
        }
        /// <summary>
        /// решаем квадратное уравнение
        /// </summary>
        static void ThreeTask()
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());

            double Discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (Discriminant > 0)
            {
                double xOne = (-b + Math.Sqrt(Discriminant) / 2 * a);
                double xSecond = (-b - Math.Sqrt(Discriminant) / 2 * a);
                Console.Write("Корни уравнения равны: {0} и {1}", xOne, xSecond);
            }
            else if (Discriminant == 0)
            {
                double x = -(b / 2 * a);
                Console.Write("Корни уравнения равны: {0}", x);
            }
            else if (a == 0 & b != 0)
            {
                double xOne = (-b + Math.Sqrt(Discriminant) / 2 * a);
                double xSecond = (-b - Math.Sqrt(Discriminant) / 2 * a);
                Console.Write("Корни уравнения равны: {0} и {1}", xOne, xSecond);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

        }
        /// <summary>
        /// решаем уравнение a*x+b=0
        /// </summary>
        static void FourTask()
        {
            float a, b;
            Console.Write("Введите число а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine("x равен: ", -b / a);
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("На ноль делить нельзя."); //на ноль делить нельзя
            }
            else
            {
                Console.WriteLine(-b / a);
            }
        }
        /// <summary>
        /// Дано натуральное число n < 1000. Определить количество цифр в числе
        /// </summary>
        static void FiveTask()
        {
            Console.Write("Введите натуральное число меньше тысячи: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 999 && number >= 100)
            {
                Console.WriteLine("Число {0} имеет 3 цифры в числе", number);
            }
            else if (number <= 100 && number >= 10)
            {
                Console.WriteLine("Число {0} имеет 2 цифры в числе", number);
            }
            else if (number < 10)
            {
                Console.WriteLine("Число {0} имеет 1 цифру в числе", number);
            }

        }
        /// <summary>
        /// Даны стороны треугольника a, b, c. Определить вид треугольника: а) равносторонний б) равнобедренный в) разносторонний
        /// </summary>
        static void SixTask()
        {
            Console.Write("Введите первую сторону: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третью ссторону: ");
            double c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (a == b && b != c)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник разносторонний");
            }
        }
        /// <summary>
        /// Определить, поместится ли квадрат со стороной a в круг с радиусом r
        /// </summary>
        static void SevenTask(int a, int r)
        {
            //Console.WriteLine(a*r);

            if (a < r)
            {
                Console.WriteLine("квадрат со стороной {0} поместится в круг с радиусом {1}", a, r);
            }
            else
            {
                Console.WriteLine("квадрат со стороной {0} не поместится в круг с радиусом {1}", a, r);//
            }

        }
        /// <summary>
        /// Даны три точки с координатами, определить какая ближе расположена к началу координат
        /// </summary>
        static void EightTask()
        {
            int xOne = 1;
            int yOne = 1;
            int xTwo = 1;
            int yTwo = 1;
            int xThree = 1;
            int yThree = 1;

            double onePoint = Math.Sqrt(Math.Pow(xOne, 2) + (Math.Pow(yOne, 2)));
            double secondPoint = Math.Sqrt(Math.Pow(xTwo, 2) + Math.Pow(yTwo, 2));
            double thirdPoint = Math.Sqrt(Math.Pow(xThree, 2) + Math.Pow(yThree, 2));

            if (onePoint < secondPoint && onePoint < thirdPoint)
            {
                Console.WriteLine("1 ближе");
            }
            if (secondPoint < onePoint && secondPoint < thirdPoint)
            {
                Console.WriteLine("2 ближе");
            }
            if (thirdPoint < onePoint && thirdPoint < secondPoint)
            {
                Console.WriteLine("3 ближе");
            }
            else if (onePoint == secondPoint && secondPoint == thirdPoint)
            {
                Console.WriteLine("точки одинаково расположены от начала координат");
            }

        }
        /// <summary>
        /// написать программу калькулятор
        /// </summary>
        static void NineTask()
        {
            Console.Write("Введите первое целое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Выберите действие: ");
            string action = Console.ReadLine();


            if (action == "*")
            {
                Console.WriteLine("Умножение двух чисел равно: {0}", a * b);

            }
            if (action == "/")
            {
                Console.WriteLine("Деление двух чисел равно: {0}", a / b);
            }
            if (action == "+")
            {
                Console.WriteLine("Сложение двух чисел равно: {0}", a + b);
            }
            if (action == "-")
            {
                Console.WriteLine("Вычитание двух чисел равно: {0}", a - b);
            }


            else
            {
                Console.WriteLine("действие не выбрано!");
                NineTask();
            }
        }
        /// <summary>
        /// Даны стороны треугольника a, b, c. Определить вид тре-
        ///угольника: а) остроугольный б) прямоугольный в) тупо-
        ///угольный.Указание: Первоначально необходимо найти
        ///максимальную из сторон.Затем проверить для нее вы-
        ///полнение соотношения c2 > a2 + b2.Если оно выполня-
        ///ется, то треугольник тупоугольный.Если это равенство,
        ///прямоугольный.В ином случае - остроугольный.
        /// </summary>
        static void TenTask()
        {
            Console.Write("Задайте первую сторону треугольника: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Задайте вторую сторону треугольника: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Задайте третью сторону треугольника: ");
            int c = int.Parse(Console.ReadLine());

            if (a > c && c > b)
            {
                Console.Write("наибольшая сторона - {0}", c);
                if (c > a + b)
                {
                    Console.Write("треугольник тупоугольный");
                }
                else if (c == a + b)
                {
                    Console.Write("треугольник прямоугольный");
                }
                else
                {
                    Console.Write("треугольник остроугольный");
                }
            }
            else if (b > c && b > a)
            {
                Console.Write("наибольшая сторона - {0}", b);
                if (b > a + c)
                {
                    Console.Write("треугольник тупоугольный");
                }
                else if (b == a + c)
                {
                    Console.Write("треугольник прямоугольный");
                }
                else
                {
                    Console.Write("треугольник остроугольный");
                }
            }
            else
            {
                Console.Write("наибольшая сторона - {0}", a);
                if (a > c + b)
                {
                    Console.Write("треугольник тупоугольный");
                }
                else if (a == c + b)
                {
                    Console.Write("треугольник прямоугольный");
                }
                else
                {
                    Console.Write("треугольник остроугольный");
                }
            }
        }
        /// <summary>
        /// Дано натуральное число меньше 1000. Получить из него новое число, чтобы все цифры в нем распологались по возрастанию
        /// </summary>
        static void ElevenTask()
        {
            Console.Write("Задайте натуральное число меньше 1000:  ");
            int rndNum = int.Parse(Console.ReadLine());

            int a = rndNum / 100; //7
            int b = rndNum / 10; //8
            b %= 10;
            int c = rndNum % 10; //9

            int newNum;

            if (a <= b && a <= c && b >= c)
            {
                newNum = (a * 100) + (b * 10) + c;
                Console.WriteLine(newNum);
            }
            if (a <= b && a <= c && b <= c)
            {
                newNum = (a * 100) + (b * 10) + c;
                Console.WriteLine(newNum);    //798
            }
            if (b <= a && b <= c && a <= c)
            {
                newNum = (b * 100) + (a * 10) + c;
                Console.WriteLine(newNum);
            }
            if (c <= a && c <= b && b <= a)
            {
                newNum = (c * 100) + (b * 10) + a;
                Console.WriteLine(newNum);
            }
        }
        ///<summary>
        ///Введен символ. Определить, какой это символ: буква, цифра, знак операции, другое.
        ///</summary>
        static void TvelfeTask()
        {
            Console.Write("Введите цифру любого символа: {0}:1, {1}:/, {2}:a ",1,2,3);
            int symbol = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case 1:
                    Console.WriteLine("Введена цифра один"); ;
                    break;
                case 2:
                    Console.WriteLine("Введен знак деления");
                    break;
                case 3:
                    Console.WriteLine("Введена буква а");
                    break;
         
                default:
                    Console.WriteLine("Введено что-то другое");
                    break;
            }
        }
        /// <summary>
        /// Введено целое число. Если это цифра, вывести ее словесное обозначение(т.е.если введено 9, должно быть выведено девять). 
        /// В противном случае вывести число внеизменном виде.
        /// </summary>
        static void ThreeteenTask()
        {
            Console.Write("Введите любую цифру или число: ");
            string anyNumber = Console.ReadLine();
            int a = int.Parse(anyNumber);

            if (a<=10)
            {
                Console.WriteLine(anyNumber);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
        /// <summary>
        /// В ящике хранится 20 перчаток: 5 пар чёрных, 3 пары коричневых и 2 пары серых. Вы выбираете перчатки в темноте и можете посмотреть, что вы выбрали, только после того, как выбор сделан. 
        /// Чему равно минимальное количество перчаток, которые надо взять из ящика, чтобы гарантировано получить: 
        ///а) по крайней мере одну подходящую bпару;
        ///б) по крайней мере одну подходящую пару каждого цвета? 
        /// </summary>
        static void GlovesOfTask()
        {
            int quantityGlovesBlack = 5;
            int quantityGlovesGray = 3;
            int quantityGlovesBrown = 2;

            int sumOfGloves = (quantityGlovesBlack + quantityGlovesBrown + quantityGlovesGray)*2;

            int someCoupleGloves = sumOfGloves / 2 + 1;
            Console.WriteLine("Сколько нужно взять перчаток чтобы получилась хоть одна пара? Ответ: {0}",someCoupleGloves);

            int coupleGloves = sumOfGloves - 1;
            Console.WriteLine("Сколько нужно взять перчаток чтобы получились три пары? Ответ: {0}", coupleGloves);

        }
        /// <summary>
        /// Изучение ключевого слова TryParse
        /// </summary>        
        static void ImportantWordParse()
        {
            string str = "34";

            bool result = int.TryParse(str,out int a);

            if (result)
            {
                Console.Write("Значение переменной a равно: {0}",a);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
        ///<summary>
        ///Введен символ. Определить, какой это символ: буква, цифра, знак операции, другое - 2 вариант решения.
        ///</summary>
        static void SixteenTask()
        {
            Console.WriteLine("Введите любой символ");
            string anySymbol = Console.ReadLine();

            switch (anySymbol)
            {
                case "w":
                    Console.WriteLine("Введена буква");
                    break;
                case "/":
                    Console.WriteLine("Введен знак операции");
                    break;
                case "1":
                    Console.WriteLine("Введена цифра");
                    break;
                default:
                    Console.WriteLine("Введено что-то другое");
                    break;
            }
        }
        /// <summary>
        /// Даны числа А, В, С. Удвоить эти числа если А>B>=C. И заменить их абсолютными значениями если это не так.
        /// </summary>
        static void SeventeenTask()
        {
            {
                double a = 6.8;
                int b = 4;
                int c = 2;

                if (a > b && b >= c)
                {
                    Console.WriteLine(a * 2);
                    Console.WriteLine(b * 2);
                    Console.WriteLine(c * 2);

                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }

            }
        }
        ///<summary>
        /// Простой конвертер валют
        /// </summary>
        
        static void Eighteen()
        {
            Console.WriteLine("Введите количество рублей для конвертации в другую валюту");
            int rubble = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите валюту - euro или dollar");
            string valute = Console.ReadLine();
            
            
            switch (valute)
            {
                case "euro":
                    int eur = rubble / 70;
                    Console.Write("{0} рублей равно {1} евро", rubble, eur);
                    break;

                case "dollar":
                    int usd = rubble / 80;
                    Console.Write("{0} рублей равно {1} долларам", rubble, usd);
                    break;
            }
        }
    }

}