using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream iofile;
            int tam;
            char x;

            iofile = new System.IO.FileStream("teste.txt",
                                               System.IO.FileMode.Open,
                                               System.IO.FileAccess.ReadWrite);

            tam = (int)iofile.Length;
            for (int i = 0; i < tam; ++i)
            {
                x = (char)(iofile.ReadByte() + Primos() );
                --iofile.Position;
                iofile.WriteByte((byte)x);
            }
            iofile.Close();
        }

        static int Primos()
        {
            int[] primos = { 2, 3, 5, 7, 11, 13, 17 };
            for(int a = 0; a < primos.Length; ++a)
            {
                return primos[a];
            }
            return 0;
        }
    }
}

