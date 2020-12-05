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

            int[][] зубчатый_массив = new int[3][];

            int[,,] thirdDArray = new int[3, 4, 5];

            #region Вывод трехмерного массива
            for (int i = 0; i < thirdDArray.GetLength(0); i++)
            {
                for (int j = 0; j < thirdDArray.GetLength(1); j++)
                {
                    for (int l = 0; l < thirdDArray.GetLength(2); l++)
                    {
                        Console.Write("[" + thirdDArray[i, j, l] + "]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion

            зубчатый_массив[0] = new int[] { 3, 7, 6, 213, 4324, 24,26,536,6 ,356};
            зубчатый_массив[1] = new int[] { 3, 7, 6,536,6 ,356};
            зубчатый_массив[2] = new int[] { 3, 536,6 ,356};

            #region Вывод зубчатого массива
            for (int i = 0; i < зубчатый_массив[0].Length; i++)
            {
                Console.Write("[" + зубчатый_массив[0][i] + "]");
            }
            Console.WriteLine();
            for (int i = 0; i < зубчатый_массив[1].Length; i++)
            {
                Console.Write("[" + зубчатый_массив[1][i] + "]");
            }
            Console.WriteLine();
            for (int i = 0; i < зубчатый_массив[2].Length; i++)
            {
                Console.Write("[" + зубчатый_массив[2][i] + "]");
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            #endregion

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
            Console.WriteLine("Зубчатый массив");

            int[][,] зубачатый_двумерный_массив = new int[2][,];
            зубачатый_двумерный_массив[0] = new int[,] { { 34, 35, 64 }, { 34, 35, 64} };
            зубачатый_двумерный_массив[1] = new int[,] { { 34, 35, 64, 56, 56, 3,56, 35,6 ,3,6 }, { 34, 35, 64, 56, 56, 3, 56, 35, 6, 3, 6 }, { 34, 35, 64, 56, 56, 3, 56, 35, 6, 3, 6 } };
            
            #region Вывод двумерного зубчатого массива
            for (int i = 0; i < зубачатый_двумерный_массив.Length; i++)
            {
                for (int j = 0; j < зубачатый_двумерный_массив[i].GetLength(0); j++)
                {
                    for (int k = 0; k < зубачатый_двумерный_массив[i].GetLength(1); k++)
                    {
                        Console.Write("[" + зубачатый_двумерный_массив[i][j, k] + "]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion

            string[] users = { "Petr Petrov", "Sidorov Sidor", "Ivan Ivanov" };
            Console.Write("Введите данные: ");
            string name = Console.ReadLine();

            for (int i = 0; i < users.Length; i++)
            {
                if (name == users[i])
                {
                    Console.WriteLine(true);
                    break;
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }

        


    }
}
