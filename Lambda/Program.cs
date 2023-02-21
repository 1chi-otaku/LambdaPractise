using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    delegate void MyDelegate(string message);
    delegate bool BoolIntDel(int number);
    delegate double IntIntDel(int number);
    delegate double DoubleInt(int x);
    delegate int IntArrInt(int[] arr);
    delegate void VoidArrInt(int[] arr);
    class Program
    {
       
        static void Main(string[] args)
        {
            #region #1 Создайте анонимный метод для проверки числа на чётность.Напишите код для тестирования работы метода.

            //BoolIntDel mydel = delegate (int number)
            //{
            //    return number % 2 == 0;
            //};

            //if (mydel(12) == true)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            #endregion

            #region #2 Создайте анонимный метод для подсчёта квадрата числа.Напишите код для тестирования работы метода
            //IntIntDel mydel = delegate (int number)
            //{
            //    return Math.Pow(number, 2);
            //};

            //Console.WriteLine(mydel(16));
            #endregion

            #region #3 Создайте лямбда-выражение для подсчёта куба числа. Напишите код для тестирования работы лямбды
            //DoubleInt cubeInt = i => Math.Pow(i, 3);
            //Console.WriteLine(cubeInt(2));
            #endregion
            #region #4 Создайте лямбда-выражение для проверки является ли заданный день днём программиста(день программиста – 256 день года).Напишите код для тестированияработы лямбды
            //BoolIntDel isDay = i => i == 256;
            //Console.WriteLine(isDay(256));
            #endregion
            #region #5 Создайте лямбда-выражение для поиска максимума в массиве.Напишите код для тестирования работы лямбды.
            //int[] arr = {1, 2, 3};
            //IntArrInt Max = array => array.Max();
            //Console.WriteLine(Max(arr));
            #endregion
            #region #6 Создайте лямбда-выражение для поиска минимума в массиве.Напишите код для тестирования работы лямбды.
            //int[] arr = { 1, 2, 3 };
            //IntArrInt Min = array => array.Min();
            //Console.WriteLine(Min(arr));
            #endregion
            #region #7 Создайте лямбда-выражение для поиска нечётных чисел в массиве.Напишите код для тестирования работы лямбды
            int[] arr = { 1, 2, 3,4,5,6,7,8,9 };
            VoidArrInt Odd = array =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0) Console.Write(array[i] + "\t");
                }
            };
            Odd(arr);
            #endregion
        }
    }
}
