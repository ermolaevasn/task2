using System;
using System.IO;

namespace задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N,//размер доски
                a=0,b=0,//координаты проигрышных ситуаций
                kol=0;//счетчик для проигрышных координат
            int[,] mas = new int[270,270];//массив для хранения выигрышных и проигрышных ситуаций
            Console.WriteLine("Требуется ввести размер шахматной доски M x N ");//ввод размеров доски с проверкой
            Console.WriteLine("Введите координату M (0<M<250)");
            Vvod("координата M = ", out M);
            Proverka("координата M", ref M);
            Console.WriteLine("Введите координату N (0<N<250)");
            Vvod("координата N = ", out N);
            Proverka("координата N", ref N);

            for (int i = 0; i < 250; i++)//заполняем массив единицами(выиграет 1 игрок)
                for (int j = 0; j < 250; j++)
                    mas[i, j] = 1;

            for (int i=0;i<20;i++)//заполняем проигрышные ситуации(для 1 игрока) двойками
            {
                a += 2;
                kol++;
                b = a - kol;
                mas[a, b] = 2;
                mas[b, a] = 2;

                a += 3;
                kol++;
                b = a - kol;
                mas[a, b] = 2;
                mas[b, a] = 2;

                a += 2;
                kol++;
                b = a - kol;
                mas[a, b] = 2;
                mas[b, a] = 2;

                a += 3;
                kol++;
                b = a - kol;
                mas[a, b] = 2;
                mas[b, a] = 2;

                a += 3;
                kol++;
                b = a - kol;
                mas[a, b] = 2;
                mas[b, a] = 2;
            }
            //ЕСЛИ НЕОБХОДИМО ВЫВЕСТИ МАТРИЦУ С ВЫИГРЫШНЫМИ СИТУАЦИЯМИ

            //for (int i = 0; i < 25; i++)
            //{
            //    for (int j = 0; j < 25; j++)
            //    {
            //        if(mas[i,j]==2) Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write(mas[i, j]+"   ");
            //        Console.ResetColor();
            //    }
            //    Console.WriteLine();
            //}

            //КОНЕЦ ВЫВОДА МАТРИЦЫ

            if (mas[M - 1, N - 1] == 2) Console.WriteLine("Выиграет ВТОРОЙ игрок");//вывод результатов
            else Console.WriteLine("Выиграет ПЕРВЫЙ игрок");
            Console.ReadKey();  
        }
        static double Vvod(string s, out int n)//ввод числа
        {
            bool ok;
            string buf;
            do
            {
                Console.Write(s + " = ");
                buf = Console.ReadLine();
                ok = Int32.TryParse(buf, out n);
                if (!ok) Console.WriteLine("Введите " + s + " заново");
            } while (!ok);
            return n;
        }
        static void Proverka(string s, ref int a)//проверка ввода на отрицательность
        {
            bool ok = false;
            string buf;
            do
            {
                if ((a > 0)&&((a < 251))) ok = true;
                else
                {
                    if (!ok) Console.WriteLine("\aВведите " + s + " заново");
                    Console.Write(s + " = ");
                    buf = Console.ReadLine();
                    ok = Int32.TryParse(buf, out a);
                    ok = false;
                }
            } while (!ok);
        }
    }
}
