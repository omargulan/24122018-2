using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw_24122018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Написать программу, которая считывает символы с клавиатуры, " +
                "пока не будет введена точка. " +
                "Программа должна сосчитать количество введенных пользователем пробелов: ");
            Console.WriteLine("Введите символы с пробелом: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = (char)Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Кол-во пробелов: " + spaceCount);
            Console.ReadLine();
            Console.WriteLine("Введите Enter");
            Console.ReadLine();
            /*****************************************************************************************************/
            Console.WriteLine("2.Ввести с клавиатуры номер трамвайного билета (6-значное число)" +
                " и про-верить является ли данный билет счастливым " +
                "(если на билете напечатано шестизначное число, " +
                "и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым)");
            Console.Write("Введите номер трамвайного билета:  ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => Convert.ToInt32(s)).ToArray();
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
                }

                else Console.WriteLine("У вас не счастливый билет: {0} не равно {1}", leftNumber, rightNumber);
            }

            else Console.WriteLine("Число введено не правильно!");


            Console.ReadLine();
            Console.WriteLine("Введите Enter");
            Console.ReadLine();
            /*****************************************************************************************************/
            Console.WriteLine("3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. " +
                "Используя эту информацию, написать программу, " +
                "которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.");
            int e, count = 0;
            char j;
            do
            {
                Console.WriteLine("Введите символ");
                do
                {
                    e = Console.Read();
                    j = (char)e;
                } while (j == '\n' | j == '\r');



                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    j = (char)e;
                    Console.WriteLine(j);
                    count++;

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    j = (char)e;
                    Console.WriteLine(j);
                    count++;
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    j = (char)e;
                    Console.WriteLine(j);
                }


            } while (e != 46);
            Console.WriteLine("Всего введено " + count + " символов");


            Console.ReadLine();
            Console.WriteLine("Введите Enter");
            Console.ReadLine();
            /*****************************************************************************************************/
            Console.WriteLine("4.	Даны целые положительные числа A и B (A < B). " +
                "Вывести все целые числа от A до B включительно; " +
                "каждое число должно выводиться на новой строке;" +
                " при этом каждое число должно выводиться количество раз, равное его значению. ");
            int a = 3, b = 7;
            for (int i = a; i <= b; ++i)
            {
                for (int k = 0; k < i; ++k)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            }
            //Console.ReadKey();
            Console.ReadLine();
            Console.WriteLine("Введите Enter");
            Console.ReadLine();
            /*****************************************************************************************************/
            Console.WriteLine("Введите число: ");
           
            int number=Console.Read();

            while (number != 0)
            {
                Console.WriteLine(number % 10);
                number /= 10;
            }
            
            Console.ReadLine(); Console.ReadLine();
        }
    }
}
