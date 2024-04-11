/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[4, 4];
        
        // Заполнение массива из 0 и 1
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array[i, j] = (i + j) % 2;
            }
        }
        
        // Вывод массива
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}