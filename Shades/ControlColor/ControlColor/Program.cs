using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlColor
{
    class Program
    {
        static int Cols = 4;
        static int Rows = 5;
        static int[,] A = new int[Rows, Cols];
        static bool chamday = true;
        static int cot = -1;
        static int hang = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    A[i, j] = 0;

            while (true)
            {
                if (chamday)
                {
                    cot = ThemO();
                    hang = 0;
                    chamday = false;
                    Draw();
                    Console.ReadKey();
                }
                else
                {
                    if (hang == Rows - 1)
                    {
                        chamday = true;
                        continue;
                    }
                    else
                    {
                        if (A[hang, cot] != 4 && A[hang + 1, cot] == A[hang, cot])
                        {
                            A[hang + 1, cot] += A[hang, cot];
                            A[hang, cot] = 0;
                            hang = hang + 1;
                        }
                        else if (A[hang + 1, cot] == 0)
                        {
                            A[hang + 1, cot] = A[hang, cot];
                            A[hang, cot] = 0;
                            hang = hang + 1;
                        }
                        else
                            chamday = true;
                    }

                    Draw();
                    Console.ReadKey();

                    KT();
                    Draw();
                    Console.ReadKey();
                    
                }
            }
        }

        

        static void KT()
        {
            for (int i = Rows - 1; i >= 0; i--)
                if (KTHang(i))
                    // day cac hang tren xuong
                    DayHangXuong(i);

                //for (int j =0; j < Cols; j++)
                    
        }

        static void DayHangXuong(int i)
        {
            for (int k = i; k > 0; k--)
                for (int j = 0; j < Cols; j++)
                    A[k, j] = A[k - 1, j];
            for (int j = 0; j < Cols; j++)
                A[0, j] = 0;
        }

        static bool KTHang(int i)
        {
            int tam = A[i, 0];
            if (tam == 0) return false;
            for (int j = 1; j < Cols; j++)
                if (A[i, j] != tam)
                    return false;
            return true;
        }

        static void Draw()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
        }

        static int ThemO()
        {
            Random r = new Random();
            int j = r.Next(0, 4);

            A[0, j] = 1;
            return j;
        }
    }
}
