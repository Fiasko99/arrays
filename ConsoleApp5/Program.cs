using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // одномерные массивы
            int[] arrNull = new int[5]; // для создания массива из 5ти элементов с 0 в каждом элементе
            int[] arrNotNull = { 23, 35, 656, 425, -122 }; // Для создания массива из 5 элементов с указанным значением

            // двумерные массивы
            int[,] tdArrNull = new int[2, 2]; // для создания двумерного массива из таблицы размером в две строки и две колонки с 0 значениями
            int[,] tdArrNotNull = { { 2, 5, 7, 8}, { 5, 8, 32, -6} }; // для создания двумерного массива из таблицы размером в две строки и четыре колонки

            #region Для вывода в консоль одномерных массивов (нажми на меня чтобы увидеть строки кода)
            Console.WriteLine("Одномерные массивы: ");
            for (int i = 0; i < arrNull.Length; i++)
            {
                Console.Write("[" + arrNull[i] + "]");
            }
            Console.WriteLine();
            for (int i = 0; i < arrNotNull.Length; i++)
            {
                Console.Write("[" + arrNotNull[i] + "]");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Для вывода в консоль двумерных массивов (нажми на меня чтобы увидеть строки кода)
            Console.WriteLine("Двумерные массивы: ");
            
            for (int i = 0; i < tdArrNull.GetLength(0); i++)
            {
                for (int j = 0; j < tdArrNull.GetLength(1); j++)
                {
                    Console.Write("[" + tdArrNull[i, j] + "]");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < tdArrNotNull.GetLength(0); i++)
            {
                for (int j = 0; j < tdArrNotNull.GetLength(1); j++)
                {
                    Console.Write("[" + tdArrNotNull[i, j] + "]");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
