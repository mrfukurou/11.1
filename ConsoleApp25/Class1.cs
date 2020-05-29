using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class mas
    {

        int[,] IntArray;
        int n;

        public mas(int N)
        {
            n = N;
            IntArray = new int[n, n];
        }

        public int[,] Input()
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    IntArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return IntArray;

        }

        public void Output()

        {
            for (int i = 0; i < IntArray.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < IntArray.GetLength(1); ++j)
                    Console.Write("{0,5} ", IntArray[i, j]);

        }

        public void summ(int m)
        {
           
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += IntArray[i, m];
                
            }
            Console.WriteLine("Сумма столбцa: " + sum);
        }


        public int yong
        {
            get
            {
                int zero = 0;
                for (int i = 0; i < IntArray.GetLength(0); i++)
                {
                    for (int j = 0; j < IntArray.GetLength(1); j++)
                    {
                        if (IntArray[i, j] == 0)
                            zero++;
                    }
                }
                return zero;
            }
        }

        public int Scalar
        {
            set
            {
                for (int i = 0; i < IntArray.GetLength(0); i++)
                {
                    IntArray[i, i] = value;
                }
            }
        }
    }
}


