using System;//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello world");//static void -обращаемся в метод, не создавая объект
            //Console.Write("Введите имя: ");//вывод без \n

            //string str = Console.ReadLine();// ввод от пользователя

            //Console.Clear();//
            //Console.WriteLine("Привет, " + str);

            task12();
        }

        static void task1()
        {
            /*1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
             * Программа должна сосчитать количество введенных пользователем пробелов.*/

            string str = "";
            int i = 0;
            do
            {
                str += Console.ReadLine();//str=str+cr();
                i++;
                Console.Clear();
            } while (!str.Contains(".")); // метод проверки на включение

            int countSpace = str.Count(w => w == ' '); //технология Linque( =>-лямда-выражение)
            /*              
            foreach(char item in str)
             i++      */

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if (str[k] == ' ')
                    b++;
            }
            Console.WriteLine("Кол-во символов: " + i);
            Console.WriteLine("Кол-во пробелов: " + countSpace);
            Console.WriteLine("Кол-во ' ': " + b);
        }

       static void task2()
        {
            /*2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить 
             * является ли данный билет счастливым (если на билете напечатано шестизначное число, 
             * и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым). */


            string ticket = Console.ReadLine();
            if (ticket.Length==6)
            {
                //сумма первых 3 цифр
                int sum1 = ticket[0] + ticket[1] + ticket[2];
                //сумма last 3 цифр
                int sum2 = ticket[3] + ticket[4] + ticket[5];

                if (sum1 == sum2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Билет счастливый! ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Билет не счастливый! ");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длина билета не соответствует формату! ");
            }
        }

       static void task3()
        {
            /*4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно;
             *  каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз,
             *   равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод: 
3 3 3 
4 4 4 4 
5 5 5 5 5 
6 6 6 6 6 6 
7 7 7 7 7 7 7 
*/
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void task4()
        {
            /*5.	Дано целое число N (> 0), найти число, полученное при прочтении числа 
             * N справа налево. Например, если было введено число 345, то программа должна вывести число 543.*/

            string a = Console.ReadLine();
            if (Int32.Parse(a)> 0)
            {
for (int i=a.Length-1;i>=0;i--)
                {
                    Console.Write(a[i]);
                }
                Console.WriteLine();
            }
        }

        static void task5()
        {
            /*6.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.*/

            Random r = new Random(); //создали класс

            string str = r.Next(1, 30) + "  " + r.Next(1, 30) + "  " + r.Next(1, 30);
            Console.WriteLine(str);
        }

        static void task6()
        {
            /*8.	Дано расстояние в сантиметрах. Найти число полных метров в нем.*/

            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a / 100+" m");

        }

        static void task7()
        {
            /*11.	Вычислить значение логического выражения при следующих значениях
             *  логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
a.	А или В; 
b.	А и В; 
c.	В или С.
*/

            bool a, b, c;
            a = bool.Parse(Console.ReadLine());
            b = bool.Parse(Console.ReadLine());
            c = bool.Parse(Console.ReadLine());

            if (a||b)
            {
                Console.WriteLine("true");
            }
           if (a && b)
            {
                Console.WriteLine("false");
            }
           if (b||c)
            {
                Console.WriteLine("false");
            }

        }
        static void task8()
        {
            /*Напечатать "столбиком": 
a.	все целые числа от 20 до 35;
b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
*/           
            Console.WriteLine(" Введите пункт: ");
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        for ( int i=20;i<=35;i++)
                        {
                            Console.WriteLine(i);
                        }
                    }break;
                case 2:
                    {
                        int b = Int32.Parse(Console.ReadLine());
                            for (int i=10;i<=b;i++)
                        {
                            Console.WriteLine(i * i);
                        }
                    }break;

                case 3:
                    {
                        int a = Int32.Parse(Console.ReadLine());
                        if (a < 50)
                        {
                            for (int i = a; i <= 50; i++)
                            {
                                Console.WriteLine(i * i*i); // Console.WriteLine("{0}",Math.Pow(i,3))
                            }
                        }
                    }break;

                case 4:
                    {
                        int a = Int32.Parse(Console.ReadLine());
                        int b = Int32.Parse(Console.ReadLine());

                        for (int i = a; i < b; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
            }

        }

        static void task9()
        {
            /*16.	вычисления значения функции y= 7x2-3x+6 при любом значении x;*/


        }

       static void task10()
        {
            /*31.	Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?*/

            Console.Write("Введите расстояние в метрах a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах b: ");
            int b = Int32.Parse(Console.ReadLine());

            if (a/1000 < (b * 0.305))
                Console.WriteLine("a<b");
            else
                Console.WriteLine("a>b");
        }
        

        static void task11()
        {
            /* Составить программу, которая в зависимости от порядкового номера дня недели
             *  (1, 2, ..., 7) выводит на экран его название (понедельник, вторник, ..., воскресенье).*/

            //var t=DateTime.Now.DayOfWeek
            int a = Int32.Parse(Console.ReadLine());
            DayOfWeek den = (DayOfWeek)a;
            Console.WriteLine(den);

        }

        static void task12()
        {
            /*37.	Составить программу, которая в зависимости от порядкового номера месяца (1, 2, ..., 12)
             *  выводит на экран количество дней в этом месяце. Рассмотреть два случая: 
a.	год не является високосным (см. задачу 4.65); 
b.	год может быть високосным (информация об этом вводится с клавиатуры).
*/
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.DaysInMonth(2018, a));

        }

    }
}
