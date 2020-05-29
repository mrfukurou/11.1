using System;

namespace ConsoleApp25
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                mas ms = new mas(n);
                int[,] IntArray = ms.Input();
                Console.WriteLine("Матрица: ");
                ms.Output();
                Console.Write("Введите номер столбца:");
                int b = Convert.ToInt32(Console.ReadLine());
                ms.summ(b);
                Console.WriteLine("Количество нулевых элементов: " + ms.yong);
                Console.Write("Введите скаляр: ");
                int m = Convert.ToInt32(Console.ReadLine());
                ms.Scalar = m;
                ms.Output();
            }
            catch { Console.Write("Некорректный ввод!"); }
        }
    }
}
