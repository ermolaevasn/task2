using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            Console.WriteLine("Требуется ввести размер шахматной доски M x N ");
            Console.WriteLine("Введите координату M");
            Vvod("координата M = ", out M);
            Proverka("координата M", ref M);
            Console.WriteLine("Введите координату N");
            Vvod("координата N = ", out N);
            Proverka("координата N", ref N);

            if (M == N) Console.WriteLine("Выиграет ПЕРВЫЙ игрок");
            else
                if ((M == 2) && (N == 3) || (M == 3) && (N == 2)) Console.WriteLine("Выиграет ВТОРОЙ игрок");
            else if ((M % 2==0)&&(N % 2 == 0)) Console.WriteLine("Выиграет ВТОРОЙ игрок");
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
                if (a > 0) ok = true;
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
